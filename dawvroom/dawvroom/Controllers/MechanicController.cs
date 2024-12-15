using Microsoft.AspNetCore.Mvc;

namespace dawvroom.Controllers
{
    public class MechanicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
