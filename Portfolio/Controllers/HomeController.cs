using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public PortfolioClase datos;
        public Persona persona;
        public IActionResult Index()
        {
            Persona p = new Persona()
            {
                Nombre = "Jared",
                Edad = 22,
                Perfil = "faker.jpg",
            };

            List<Proyecto> lista = new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL = "/imagenes/amazon.jpg"
                },
                new Proyecto
                {
                    Titulo = "New York Times",
                    Descripcion = "Página de noticias en React",
                    Link = "https://nytimes.com",
                    ImagenURL = "/imagenes/nyt.jpg"
                },
                new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/reddit.jpg"
                },
                new Proyecto
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en línea para comprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/imagenes/steam.jpg"
                },
            };

            HomeViewModel m = new HomeViewModel() { 
                P=p,
                Proyectos=lista
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
