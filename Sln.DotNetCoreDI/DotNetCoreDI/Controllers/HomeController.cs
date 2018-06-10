using DotNetCoreDI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILocalPCInfos _localpcinfos;

        public HomeController(ILocalPCInfos localpcinfos)
        {
            _localpcinfos = localpcinfos;
        }


        public IActionResult Index()
        {
            var serverTime = _localpcinfos.Now;
            
            if (serverTime.Hour < 12)
            {
                ViewData["Message"] = "It's morning here - Good Morning!";
                
            }
            else if (serverTime.Hour < 17)
            {
                ViewData["Message"] = "It's afternoon here - Good Afternoon!";
            }
            else
            {
                ViewData["Message"] = "It's evening here - Good Evening!";
            }

            ViewData["IPAddress"] = _localpcinfos.IPAddress;

            return View();
        }
    }
}
