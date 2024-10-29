using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
