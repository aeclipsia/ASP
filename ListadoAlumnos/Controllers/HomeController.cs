using ListadoAlumnos.Interfaces;
using ListadoAlumnos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ListadoAlumnos.Controllers
{
    public class HomeController : Controller
    {
        private static int posicionAlumno = 0;
        private IAlumnosService alumnos;

        public HomeController(IAlumnosService data)
        {
            this.alumnos = data;
        }
        public IActionResult Index()
        {
            return View(this.alumnos.GetAlumnos());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AlumnoModel a)
        {
            if (ModelState.IsValid)
            {
                this.alumnos.addAlumno(a);
                return Redirect("Index");
            }
            return View(a);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            posicionAlumno = id - 1;
            return View(this.alumnos.GetAlumno(id - 1));

        }

        [HttpPost]
        public IActionResult Edit(AlumnoModel a)
        {
            this.alumnos.GetAlumno(posicionAlumno).Telefono = a.Telefono;
            this.alumnos.GetAlumno(posicionAlumno).Curso = a.Curso;
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            posicionAlumno = id - 1;
            return View(this.alumnos.GetAlumno(id - 1));
        }
        [HttpPost]
        public IActionResult Delete(AlumnoModel a)
        {
            this.alumnos.deleteAlumno(posicionAlumno);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(this.alumnos.GetAlumno(id - 1));
        }
    }
}
