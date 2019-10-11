using System;

namespace DotNetCoreDI.Service
{
    public class CommonData : ICommonData
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
        public string GetMachineName()
        {
            return "Machine Name: " + Environment.MachineName.ToString();
        }
    }
}
