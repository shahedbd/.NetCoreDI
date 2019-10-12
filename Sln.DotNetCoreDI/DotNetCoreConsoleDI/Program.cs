using DotNetCoreConsoleDI.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotNetCoreConsoleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DI Setup
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICommonData, CommonData>()
                .BuildServiceProvider();


            var _commonData = serviceProvider.GetService<ICommonData>();

            Console.WriteLine("Current Time: " + _commonData.GetCurrentDateTime());
            Console.WriteLine("Machine Name: " + _commonData.GetMachineName());
            Console.ReadKey();

        }
    }
}
