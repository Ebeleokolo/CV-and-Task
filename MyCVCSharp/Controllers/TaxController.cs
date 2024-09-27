using Microsoft.AspNetCore.Mvc;
using MyCVCSharp.Models;


namespace MyCVCSharp.Controllers
{
    public class TaxController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateTax(TaxModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateTax();

                return View("Index", model);
            }

            return View("Index", model);
        }
    }
}