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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ciclos c)
        {
            if (!ModelState.IsValid)
                return View(c);
            if (this.ciclosService.FindCiclo(c.siglas) != null)
            {
                ModelState.AddModelError(nameof(c.siglas), $"El ciclo {c.siglas} ya existe");
                return View();
            }
            await this.ciclosService.AddCiclo(c); 
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string siglas)
        {
            await this.ciclosService.DeleteCiclo(siglas);
            return RedirectToAction("Index");
        }
    }
}
