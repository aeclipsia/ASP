using Practica5_1.Models;

namespace Practica5_1.Interfaces
{
    public interface ICiclosService
    {
        public List<Ciclos> GetCiclos();
        public Ciclos FindCiclo(string siglas);
        public Task AddCiclo(Ciclos c);
        public Task DeleteCiclo(string siglas);
    }
}
