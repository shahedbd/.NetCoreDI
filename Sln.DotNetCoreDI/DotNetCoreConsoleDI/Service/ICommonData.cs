using System;

namespace DotNetCoreConsoleDI.Service
{
    public interface ICommonData
    {
        DateTime GetCurrentDateTime();
        string GetMachineName();
    }
}
