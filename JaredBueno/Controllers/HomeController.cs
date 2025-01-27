using JaredBueno.Interfaces;
using JaredBueno.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JaredBueno.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioServicio usuarioServicio;

        public HomeController(IUsuarioServicio usuarioServicio)
        {
            this.usuarioServicio = usuarioServicio;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String Usuario, String Password)
        {
            UsuarioModel usuario = usuarioServicio.isUsuario(Usuario,Password);
            if (usuario == null)
            {
                return RedirectToAction("PasswordIncorrect");
            }
            if(usuario is AlumnoModel alumno)
            {
                return RedirectToAction("AlumnoDetalles", alumno);
            }
            if(usuario is ProfesorModel)
            {
                return RedirectToAction("ProfesorView");
            }
            return View();
        }

        public IActionResult PasswordIncorrect()
        {
            ModelState.AddModelError("", "No está registrado o la contraseña es incorrecta. Revisa tus datos.");
            return View("Index");
        }
        public IActionResult AlumnoDetalles(AlumnoModel alumno)
        {
            return View(alumno);
        }
        public IActionResult ProfesorView()
        {
            List<AlumnoModel> alumnos = usuarioServicio.getAlumnos();
            return View(alumnos);
        }
        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(AlumnoModel nuevo)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Datos incorrectos");
                return View(nuevo);
            }
            if (usuarioServicio.isRepetido(nuevo.Nombre, nuevo.Password))
            {
                ModelState.AddModelError("", "El usuario y/o contraseña ya existe");
                return View(nuevo);
            }
            if (!string.IsNullOrWhiteSpace(nuevo.IdiomasString))
            {
                //El formulario recibe un string de idiomas separado por coma. Esta lo guarda en Idiomas como una lista despues del split
                nuevo.Idiomas=nuevo.IdiomasString.Split(",").Select(x => x.Trim()).ToList();
            }

            //evitar reenvio de datos
            return RedirectToAction("Agregar", nuevo);
        }
        public IActionResult Agregar(AlumnoModel nuevo)
        {
            usuarioServicio.addAlumno(nuevo);
            return RedirectToAction("Index");
        }
        public IActionResult Editar(string Email)
        {
            UsuarioModel alumno = usuarioServicio.isUsuario(Email);
            return View(alumno);
        }
        public IActionResult CambiarPassword(string Email, string Password, string PasswordConfirm)
        {
            if (Password != PasswordConfirm)
            {
                ModelState.AddModelError("", "La contraseña tienen que ser iguales");
                UsuarioModel alumno = usuarioServicio.isUsuario(Email);
                return View("Editar", alumno);
            }
            if(usuarioServicio.cambiarPassword(Email, Password))
            {
                ModelState.AddModelError("", "La contraseña se ha modificado");
                return View("Index");
            }
            return View("Editar");
        }
    }
}
