using Microsoft.AspNetCore.Mvc;

namespace SkolmatenNyNy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
