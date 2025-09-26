using Microsoft.AspNetCore.Mvc;

namespace Attachee01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
