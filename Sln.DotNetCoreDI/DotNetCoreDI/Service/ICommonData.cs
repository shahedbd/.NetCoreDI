using System;

namespace DotNetCoreDI.Service
{
    public interface ICommonData
    {
        DateTime GetCurrentDateTime();
        string GetMachineName();
    }
}
