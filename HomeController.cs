using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication222.Models;

namespace WebApplication222.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        #region

        public IActionResult Index(string month)
        {
            string message;
            string imagePath;

            if (month == "December" || month == "January" || month == "February")
            {
                message = "You should wear winter clothes";
                imagePath = "/images/winter.png";
            }
            else if (month == "June" || month == "July" || month == "August")
            {
                message = "You should wear summer clothes";
                imagePath = "/images/summer.png";
            }
            else
            {
                message = "Mild weather – choose what you like";
                imagePath = "/images/mild.png";
            }

            ViewBag.Message = message;
            ViewBag.Image = imagePath;

            return View();
        }
        #endregion
    }
}