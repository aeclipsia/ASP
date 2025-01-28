using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practica5_1.Interfaces;
using Practica5_1.Models;
using Practica5_1.Services;

namespace Practica5_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICiclosService ciclosService;

        public HomeController(ICiclosService ciclosService)
        {
            this.ciclosService= ciclosService;
        }

        public IActionResult Index()
        {
            List<Ciclos> l = this.ciclosService.GetCiclos();
            return View(l);
        }

        public IActionResult Details(string siglas)
        {
            Ciclos c = this.ciclosService.FindCiclo(siglas);
            return View(c);
        }
    }
}
