using Practica5_1.Models;

namespace Practica5_1.Interfaces
{
    public interface ICiclosService
    {
        public List<Ciclos> GetCiclos();
        public Ciclos FindCiclo(string siglas);
    }
}
