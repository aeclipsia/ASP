using ListadoAlumnos.Interfaces;
using ListadoAlumnos.Models;

namespace ListadoAlumnos.Services
{
    public class AlumnosService:IAlumnosService
    {

        public AlumnosService()
        {
            ListadoAlumnos = new List<AlumnoModel>
            {
                new AlumnoModel
                {
                    Nombre = "Pedro",
                    Apellidos = "Diaz",
                    Telefono = "666666666"
                },
                new AlumnoModel
                {
                    Nombre = "Alejandro",
                    Apellidos = "Ruiz",
                    Telefono = "663663663"
                },
                new AlumnoModel
                {
                    Nombre = "Samuel",
                    Apellidos = "Gomez",
                    Telefono = "676767676"
                },
            };
        }

        public List<AlumnoModel> ListadoAlumnos {  get; set; }
        public IEnumerable<AlumnoModel> GetAlumnos()
        {
            return ListadoAlumnos;
        }

        public void addAlumno(AlumnoModel a)
        {
            ListadoAlumnos.Add(a);
        }

        public AlumnoModel GetAlumno(int id)
        {
            return this.ListadoAlumnos[id];
        }

        public void deleteAlumno(int id)
        {
            this.ListadoAlumnos.RemoveAt(id);
        }
    }
}
