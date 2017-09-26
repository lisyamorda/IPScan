using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPScan
{
    static class Program
    {
        struct PrivateIpPattern
        {
            public const string ip10 = @"^10(\.\d{1,3}){3}$";
            public const string ip172 = @"^172\.16(\.\d{1,3}){2}$";
            public const string ip192 = @"^192\.168(\.\d{1,3}){2}$";
            public const string ip127 = @"^127(\.\d{1,3}){3}$";
        }
    
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        static bool regTst(string pattern, string data)
        {
            Regex parser = new Regex(pattern);
            return parser.IsMatch(data);
        }
        public static bool ValidIPString(string ip)
        {
            return regTst(PrivateIpPattern.ip10,ip) || regTst(PrivateIpPattern.ip172, ip) || regTst(PrivateIpPattern.ip192, ip) || regTst(PrivateIpPattern.ip127, ip);
        }

        internal static void ScanAsync(string host, List<object> result)
        {
            TimeSpan elapsed;
            DateTime start = DateTime.Now;
            IpScanner.ScanAsync(host);
            result.AddRange(IpScanner.HostInfo);
            elapsed = DateTime.Now - start;
            
        }
    }
}
