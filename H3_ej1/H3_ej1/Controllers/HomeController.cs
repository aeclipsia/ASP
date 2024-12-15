using H3_ej1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace H3_ej1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Procesar los datos y redirigir
        [HttpPost]
        public IActionResult ProcesarDatos(Persona p)
        {
            // Pasar datos a la vista de confirmación
            ViewData["Nombre"] = p.Nombre;
            ViewData["Edad"] = p.Edad;
            if (p.Edad < 18)
            {
                ViewData["Mensaje"] = "Eres MENOR de edad";
            }
            else
            {
                ViewData["Mensaje"] = "Eres MAYOR de edad";

            }
            //Pone dodne manda la view 
            return View("Mostrar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
