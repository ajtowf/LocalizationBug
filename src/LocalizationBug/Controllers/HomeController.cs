using Microsoft.AspNetCore.Mvc;

namespace LocalizationBug.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
