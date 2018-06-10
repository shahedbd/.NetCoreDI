using DotNetCoreDI.Interfaces;
using System;

namespace DotNetCoreDI.Services
{
    public class SystemInfos : ILocalPCInfos
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }

        public string IPAddress
        {
            get { return "Your Local IP: " + Common.localIPAddress(); }
        }
    }
}
