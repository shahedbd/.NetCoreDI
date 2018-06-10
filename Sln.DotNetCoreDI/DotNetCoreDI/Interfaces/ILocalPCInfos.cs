using System;

namespace DotNetCoreDI.Interfaces
{
    public interface ILocalPCInfos
    {
        DateTime Now { get; }
        string IPAddress { get; }
    }
}
