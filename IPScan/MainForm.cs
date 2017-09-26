using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPScan
{
    delegate void wLine(string msg);
    public partial class MainForm : Form
    {
        DateTime scanStart;
        TimeSpan elapsed, total;
        private double speed = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string fullIpStart = ipZone.Text + ipPreffix.Text + ipStart.Text, fullIpEnd = ipZone.Text + ipPreffix.Text + ipEnd.Text;
            if (!(Program.ValidIPString(fullIpStart) && Program.ValidIPString(fullIpEnd)))
            {
                ipPreffix.Text = "";
                ipZone.Text = "";
                ipStart.Text = "";
                ipEnd.Text = "";
                MessageBox.Show("Неверный формат IP диапазона!", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stLog.Visible = true;
            MessageBox.Show($"Сканирование запушенно в {DateTime.Now}, будет проверенно {Math.Abs(Int32.Parse(ipStart.Text) - Int32.Parse(ipEnd.Text))} хостов.", "Старт сканирования!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnScan.Enabled = false;
            scanStart = DateTime.Now;
            elapsed = DateTime.Now - scanStart;
            lElapsed.Text = $"Elapsed: {elapsed.ToString()}.";
            Log($"Сканирование запушенно в {DateTime.Now}, будет проверенно {Math.Abs(Int32.Parse(ipStart.Text) - Int32.Parse(ipEnd.Text))} хостов.");
            bgwScanThread.RunWorkerAsync(new List<string> { ipZone.Text + ipPreffix.Text, ipStart.Text, ipEnd.Text });
        }

        private void Log(string msg)
        {
            this.BeginInvoke(new MethodInvoker(delegate {
                logConsole.Tag = (int)logConsole.Tag + 1;
                logConsole.Text += $"{(int)logConsole.Tag}:\t{msg} " + @"
";
            }));
        }
        private void bgwScanThread_DoWorkAsync(object sender, DoWorkEventArgs e)
        {
            List<object> Result = new List<object>();
            var ipInterval = new { IpHead = ((List<string>)e.Argument)[0], IpStart = Int32.Parse(((List<string>)e.Argument)[1]), IpEnd = Int32.Parse(((List<string>)e.Argument)[2]) };
            uint ipCount = (uint)Math.Abs(ipInterval.IpStart - ipInterval.IpEnd);
            for (int i = ipInterval.IpStart; (i - ipInterval.IpStart) < ipCount; i += (ipInterval.IpEnd > ipInterval.IpStart) ? (1) : (-1))
            {
                scanStart = DateTime.Now;
                string Host = ipInterval.IpHead + i;
                Log($"Старт сканирования портов на Хосте: {Host}");
                Program.ScanAsync(Host, Result);
                while (IpScanner.ActiveTasks > 0)
                {
                    total = (speed > 0) ? new TimeSpan((long)((65536.00)/(double)speed)) : TimeSpan.MaxValue;
                    bgwScanThread.ReportProgress((int)(IpScanner.PortScaned / 655.36));
                    Thread.Sleep(10);
                    elapsed = DateTime.Now - scanStart;
                }
            }
            
            e.Result = IpScanner.HostInfo;
        }
    
        private void bgwScanThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbStatus.Value = e.ProgressPercentage;
            
            speed = (double)IpScanner.PortScaned / (double)elapsed.Ticks;
            
            lTotal.Text = $"Total: {total.ToString()}";
            lElapsed.Text = $"Elapsed: {elapsed.ToString()}.";
        }

        private void bgwScanThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Log($"Сканирование окончено! Прошло времени {elapsed}");
            stLog.Visible = false;
            btnScan.Enabled = true;
            btnScan.Text = "refresh";
            bsResult.DataSource = e.Result;
            bsResult.ResetBindings(true);
            dgvResult.Update();
            dgvResult.DataSource = bsResult;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logConsole.Tag = 0;
        }

        private class ThreadCounter
        {
            internal int i;

            internal void Decrement()
            {
               i--;
            }

            internal void Increment()
            {
                i++;
            }
        }
    }
}
