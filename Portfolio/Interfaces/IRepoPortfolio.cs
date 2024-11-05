using Portfolio.Models;

namespace Portfolio.Interfaces
{
    public interface IRepoPortfolio
    {
        public Persona getPersona();
        public List<Proyecto> getProyectos();
    }
}
