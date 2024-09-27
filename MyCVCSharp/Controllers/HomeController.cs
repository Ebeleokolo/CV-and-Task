using Microsoft.AspNetCore.Mvc;
using MyCVCSharp.Models;
using System.Diagnostics;

namespace MyCVCSharp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
