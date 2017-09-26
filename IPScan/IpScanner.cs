using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPScan
{
    static class IpScanner
    {
        public static List<object> HostInfo { get; }
        public static int ActiveTasks { get; set; }
        public static int PortScaned { get; set; }
        public static bool Online = false;
        static IpScanner()
        {
            HostInfo = new List<object>();            
        }
        public static void ScanAsync(string Host)
        {
            PortScaned = 0;
            ActiveTasks = 0;
            HostInfo.Clear();
            Online = false;
            for (int i = 0; i < 64; i++)
            {
                Task<TimeSpan>.Factory.StartNew(new Func<object, TimeSpan>(OnConnect), new object[] { Host, i });
                ActiveTasks++;
            }
        }

        private static TimeSpan OnConnect(object args)
        {
            DateTime start = DateTime.Now;
            string Host = ((object[])args)[0].ToString();
            int id = (int)((object[])args)[1];
            for (int i = id*1024; i < 1024 + id*1024; i++)
            {
                if (!Online)
                {
                    using (TcpClient netClient = new TcpClient())
                    {
                        try
                        {
                            netClient.Connect(Host, i);
                            TimeSpan elapsed = DateTime.Now - start;
                            HostInfo.Add(new { Host = Host, Service = i, Delay = elapsed });
                            Online = true;
                        }
                        catch (Exception) { }
                        PortScaned++;
                    }
                }
                else {
                    break;
                }
            }
            ActiveTasks--;
            return DateTime.Now - start;           
        }

        //private static void OnConnect(object args)
        //{
        //    DateTime start = DateTime.Now;
        //    string Host = ((object[])args)[0].ToString();
        //    for (int i = (int)((object[])args)[1]; i < 256 * (int)((object[])args)[1]; i++)
        //    {
        //        using (TcpClient netClient = new TcpClient())
        //        {
        //            try
        //            {
        //                netClient.Connect(Host, i);
        //                TimeSpan elapsed = DateTime.Now - start;
        //                HostInfo.Add(new { Host = Host, Service = i, Delay = elapsed });
        //            }
        //            catch (Exception) { }
        //        }
        //    }
    }
    
}
