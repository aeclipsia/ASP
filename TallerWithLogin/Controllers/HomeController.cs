using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TallerWithLogin.Models;

namespace TallerWithLogin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
