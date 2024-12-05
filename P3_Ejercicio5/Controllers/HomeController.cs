using Microsoft.AspNetCore.Mvc;
using P3_Ejercicio5.Models;
using P3_Ejercicio5.Interfaces;
using System.Diagnostics;

namespace P3_Ejercicio5.Controllers
{
    public class HomeController : Controller
    {
        private static int posicionAlumno = 0;
        private IRepositorioAlumnos datos;

        public HomeController(IRepositorioAlumnos r)
        {
            this.datos = r;
        }
        public IActionResult Index()
        {

            return View(this.datos.GetAlumnos());
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Alumno a)
        {
            if (ModelState.IsValid)
            {
                this.datos.addAlumno(a);
                return Redirect("Index");
            }
            return View(a);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            posicionAlumno = id-1;
            return View(this.datos.GetAlumno(id-1));
        
        }

        [HttpPost]
        public IActionResult Edit(Alumno a)
        {

                this.datos.GetAlumno(posicionAlumno).Telefono = a.Telefono;
                return RedirectToAction("Index");

        }
        
        public IActionResult Delete(int id)
        {
            posicionAlumno = id - 1;
            return View(this.datos.GetAlumno(id - 1));
        }
        [HttpPost]
        public IActionResult Delete(Alumno a)
        {
            this.datos.deleteAlumno(posicionAlumno);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id) {
            return View(this.datos.GetAlumno(id - 1));
        }


        
    }
}
