using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
