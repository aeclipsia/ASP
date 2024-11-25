using EjemploControlesHTML.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploControlesHTML.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getDatos(DatosViewModel d)
        {
            return View("ShowData",d);
        }
    }
}
