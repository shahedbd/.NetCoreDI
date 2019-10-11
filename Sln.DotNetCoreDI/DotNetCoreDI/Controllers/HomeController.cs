using DotNetCoreDI.Service;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICommonData _commonData;

        public HomeController(ICommonData commonData)
        {
            _commonData = commonData;
        }


        public IActionResult Index()
        {
            var serverTime = _commonData.GetCurrentDateTime();
            
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

            ViewData["MachineName"] = _commonData.GetMachineName();

            return View();
        }
    }
}
