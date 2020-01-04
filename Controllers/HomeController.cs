using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Diagnostics;
using System.Linq;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            return View();
        }

        public IActionResult Login()
        {
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
