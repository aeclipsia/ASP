using BolsaTrabajo.Models;

namespace BolsaTrabajo.Interfaces
{
    public interface ICategoriaService
    {
        public Task<List<Categoria>> GetCategorias();
    }
}
