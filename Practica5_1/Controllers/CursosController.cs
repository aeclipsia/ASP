using Microsoft.AspNetCore.Mvc;

namespace Practica5_1.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
