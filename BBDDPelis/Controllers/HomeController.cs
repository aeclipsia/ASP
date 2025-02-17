using System.Diagnostics;
using BBDDPelis.Interfaces;
using BBDDPelis.Models;
using Microsoft.AspNetCore.Mvc;

namespace BBDDPelis.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPeliculasService peliculasService;

        public HomeController(IPeliculasService peliculasService)
        {
            this.peliculasService = peliculasService;
        }

        public IActionResult Index()
        {
            List<Peliculas> pelis=peliculasService.GetPeliculas();

            return View(pelis);
        }
    }
}
