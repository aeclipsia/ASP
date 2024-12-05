using P3_Ejercicio5.Models;

namespace P3_Ejercicio5.Interfaces
{
    public interface IRepositorioAlumnos
    {
        public IEnumerable<Alumno> GetAlumnos();

        public void deleteAlumno(int id);
        public void addAlumno(Alumno a);
        public Alumno GetAlumno(int id);
    }
}
