﻿using Portfolio.Interfaces;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class RepoPortfolio : IRepoPortfolio
    {
        public Persona getPersona()
        {
            return new Persona()
            {
                Nombre = "Jared",
                Edad = 22,
                Perfil = "faker.jpg",
            };
        }

        public List<Proyecto> getProyectos() {
            return new List<Proyecto>()
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
        }
    }
}