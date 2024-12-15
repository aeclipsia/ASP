using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TallerWithLogin.Interfaces;
using TallerWithLogin.Models;

namespace TallerWithLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuariosService usuariosService;

        public HomeController(IUsuariosService usuariosService)
        {
            this.usuariosService = usuariosService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Password) {
            UserModel user = usuariosService.isUsuario(Email, Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Revisa tus datos");
                return View();
            }
            if (user is AdministradorModel)
            {
                return RedirectToAction("Home", "Admin");
            }
            if (user is MechanicModel)
            {
                return RedirectToAction("Home", "Mechanic");
            }
            if (user is OwnerModel)
            {
                return RedirectToAction("Home", "Owner");
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
