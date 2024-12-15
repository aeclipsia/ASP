using Microsoft.AspNetCore.Mvc;

namespace dawvroom.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
