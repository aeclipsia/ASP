using BolsaTrabajo.Data;
using BolsaTrabajo.Interfaces;
using BolsaTrabajo.Models;
using Microsoft.EntityFrameworkCore;

namespace BolsaTrabajo.Services
{
    public class CategoriaService:ICategoriaService
    {
        private readonly BolsaContext context;
        public CategoriaService(BolsaContext context)
        {
            this.context = context;
        }

        public async Task<List<Categoria>> GetCategorias()
        {
            return await context.Categorias.ToListAsync();
        }
    }
}
