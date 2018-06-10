using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace DotNetCoreDI.Services
{
    public static class Common
    {
        public static string localIPAddress()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            var ipAddress = Convert.ToString(ipHostInfo.AddressList.FirstOrDefault(address => address.AddressFamily == AddressFamily.InterNetwork));
            return ipAddress;
        }
    }
}
