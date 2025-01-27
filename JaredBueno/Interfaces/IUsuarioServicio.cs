using JaredBueno.Models;

namespace JaredBueno.Interfaces
{
    public interface IUsuarioServicio
    {
        public List<AlumnoModel> getAlumnos();
        public UsuarioModel isUsuario(string email);
        public UsuarioModel isUsuario(string usuario, string password);
        public bool isRepetido(string usuario, string password);
        public void addAlumno(AlumnoModel nuevo);
        public bool cambiarPassword(string usuario, string password);
    }
}