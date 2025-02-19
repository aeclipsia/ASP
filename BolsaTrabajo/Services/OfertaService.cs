using BolsaTrabajo.Data;
using BolsaTrabajo.Interfaces;
using BolsaTrabajo.Models;
using Microsoft.EntityFrameworkCore;

namespace BolsaTrabajo.Services
{
    public class OfertaService:IOfertaService
    {
        private readonly BolsaContext context;

        public OfertaService(BolsaContext context)
        {
            this.context = context;
        }

        public async Task Create(Oferta oferta)
        {
            context.Ofertas.Add(oferta);
            await context.SaveChangesAsync();
        }

        public async Task<Oferta> GetOfertaById(int id)
        {
            return await context.Ofertas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Oferta>> GetOfertasByCategory(int catId)
        {
            return await context.Ofertas.Where(x=>x.CategoryId==catId).ToListAsync();
        }

        public async Task Delete(Oferta oferta)
        {
            context.Ofertas.Remove(oferta);
            await context.SaveChangesAsync();
        }
    }
}
