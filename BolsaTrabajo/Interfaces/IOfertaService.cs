using BolsaTrabajo.Models;

namespace BolsaTrabajo.Interfaces
{
    public interface IOfertaService
    {
        public Task Create(Oferta oferta);
        public Task<Oferta> GetOfertaById(int id);
        public Task<List<Oferta>> GetOfertasByCategory(int catId);
        public Task Delete(Oferta oferta);
    }
}
