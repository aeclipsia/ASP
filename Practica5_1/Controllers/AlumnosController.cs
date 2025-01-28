using Microsoft.AspNetCore.Mvc;
using Practica5_1.Interfaces;
using Practica5_1.Models;

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
    }
}
