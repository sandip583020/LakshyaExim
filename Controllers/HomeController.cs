using LAKSHYAEXIM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LAKSHYAEXIM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult AboutUS()
        {
            return View();
        }
        public IActionResult OurTeam()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }



        public IActionResult ProductDetails(int productId)
        {
            ViewBag.ProductId = productId;

            return View();
        }

        //public IActionResult ProductDetails()
        //{
        //    return View();
        //}
        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}