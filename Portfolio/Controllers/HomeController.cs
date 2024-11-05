using Microsoft.AspNetCore.Mvc;
using Portfolio.Interfaces;
using Portfolio.Models;
using Portfolio.Services;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRepoPortfolio data;

        public HomeController(IRepoPortfolio r)
        {
            this.data = r;
        }

        public PortfolioClase datos;
        public Persona persona;
        public IActionResult Index()
        {

            HomeViewModel m = new HomeViewModel()
            {
                P = this.data.getPersona(),
                Proyectos = this.data.getProyectos(),
            };

            return View(m);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
