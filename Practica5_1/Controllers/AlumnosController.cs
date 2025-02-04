using Microsoft.AspNetCore.Mvc;
using Practica5_1.Interfaces;
using Practica5_1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica5_1.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly IAlumnosService alumnosService;
        private readonly ICiclosService ciclosService;
        public AlumnosController(IAlumnosService alumnosService, ICiclosService ciclosService)
        {
            this.alumnosService = alumnosService;
            this.ciclosService = ciclosService;
        }
        public ActionResult Index(string siglas)
        {
            List<Alumnos> l = this.alumnosService.FindAlumnos(siglas);
            Ciclos cl = this.ciclosService.FindCiclo(siglas);
            AlumnoViewModel a = new AlumnoViewModel
            {
                alumnos = l,
                ciclo = cl.nombre
            };
            return View(a);
        }

        public ActionResult Create(string siglas)
        {
            Alumnos a = new Alumnos();
            a.Ciclo = siglas;

            return View(a);
        }

        [HttpPost]
        public ActionResult Create(Alumnos a)
        {
            if (!ModelState.IsValid)
                return View(a);
            if (alumnosService.FindAlumno(a.DNI) != null)
            {
                ModelState.AddModelError(nameof(a.DNI), $"El DNI {a.DNI} ya está dado de alta");
                return View();
            }
            this.alumnosService.addAlumnos(a);
            return RedirectToAction("Index", "Home");
        }
    }
}
