using Practica5_1.Models;

namespace Practica5_1.Interfaces
{
    public interface IAlumnosService
    {
        public List<Alumnos> FindAlumnos(string siglas);
    }
}
