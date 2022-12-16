using Microsoft.AspNetCore.Mvc;

namespace AppModelo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
