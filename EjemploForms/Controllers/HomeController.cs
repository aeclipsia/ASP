using EjemploForms.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploForms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact(ContactViewModel c)
        {
            TempData["nombre"]=c.Nombre;
            TempData["email"]=c.Email;
            TempData["mensaje"]=c.Mensaje;
            return RedirectToAction("ShowData");
        }

        public IActionResult ShowData()
        {
            ContactViewModel c = new ContactViewModel()
            {
                Nombre = TempData["nombre"].ToString(),
                Email = TempData["email"].ToString(),
                Mensaje = TempData["mensaje"].ToString()
            };
            return View("ShowData",c);
        }
    }
}
