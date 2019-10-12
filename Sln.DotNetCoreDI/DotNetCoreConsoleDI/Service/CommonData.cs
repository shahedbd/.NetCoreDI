using System;

namespace DotNetCoreConsoleDI.Service
{
    public class CommonData : ICommonData
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
        public string GetMachineName()
        {
            return Environment.MachineName.ToString();
        }
    }
}
