using ListadoAlumnos.Models;

namespace ListadoAlumnos.Interfaces
{
    public interface IAlumnosService
    {
        public IEnumerable<AlumnoModel> GetAlumnos();
        public void deleteAlumno(int id);
        public void addAlumno(AlumnoModel a);
        public AlumnoModel GetAlumno(int id);
    }
}
