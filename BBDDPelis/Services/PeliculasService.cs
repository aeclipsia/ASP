using BBDDPelis.Data;
using BBDDPelis.Interfaces;
using BBDDPelis.Models;

namespace BBDDPelis.Services
{
    public class PeliculasService : IPeliculasService
    {
        private BBDDContext _context;

        public PeliculasService(BBDDContext context)
        {
            _context = context;
        }

        public List<Peliculas> GetPeliculas() { 
            return this._context.peliculas.ToList();
        }
    }
}
