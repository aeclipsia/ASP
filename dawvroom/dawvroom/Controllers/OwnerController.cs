using Microsoft.AspNetCore.Mvc;

namespace dawvroom.Controllers
{
    public class OwnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
