using Microsoft.AspNetCore.Mvc;

namespace MyCVCSharp.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
