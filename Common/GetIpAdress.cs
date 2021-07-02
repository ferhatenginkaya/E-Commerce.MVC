using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class GetIpAddress
    {
        public static string GetHostName()
        {
            string ip = null;
            var localIpAddresses = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (var item in localIpAddresses)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ip = item.ToString();
                }
            }

            return ip;
        }
    }
}
