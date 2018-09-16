using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeachCabinReservation.Models;
using BeachCabinReservation.Models.Home;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace BeachCabinReservation.Controllers
{
    [Authorize]
    public class HomeController : BaseController<HomeController>
    {

        public HomeController(ILogger<HomeController> logger) : base(logger) { }

        public IActionResult Index()
        {
            var vm = new IndexViewModel
            {
                ConfigValue1 = "Yep",
                ConfigValue2 = 123
            };
            return View(vm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
