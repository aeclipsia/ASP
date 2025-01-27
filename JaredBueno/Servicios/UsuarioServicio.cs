using JaredBueno.Interfaces;
using JaredBueno.Models;

namespace JaredBueno.Servicios
{
    public class UsuarioServicio:IUsuarioServicio
    {
        private readonly List<UsuarioModel> usuarios;
        public UsuarioServicio()
        {
            usuarios = new List<UsuarioModel>
            {
                new ProfesorModel
                {
                    Nombre="Rosa Rodríguez García",
                    Usuario="rrodriguez",
                    Password="a12345678",
                    Email="rosa.rodriguez@salesianas.org",
                    Especialidad=EnumeradoEspecialidad.INFORMÁTICA
                },
                new AlumnoModel
                {
                    Nombre="Laura Medina Pérez",
                    Usuario="lmedina",
                    Password="l1234",
                    Email="laura.medina@esudiantes.plaza.org",
                    Ciclo=EnumeradoCiclo.DAW,
                    Curso=1,
                    Idiomas=["Inglés","Francés"]
                }
            };
        }

        public List<AlumnoModel> getAlumnos()
        {
            List<AlumnoModel> alumnos=new List<AlumnoModel>();
            foreach (var p in usuarios)
            {
                if(p is AlumnoModel)
                {
                    alumnos.Add((AlumnoModel)p);
                }
            }
            return alumnos;
        }

        public UsuarioModel isUsuario(string email)
        {
            foreach (var p in usuarios)
            {
                if (p.Email == email)
                {
                    return p;
                }
            }
            return null;
        }

        public UsuarioModel isUsuario(string usuario, string password)
        {
            foreach (var p in usuarios)
            {
                if (p.Usuario==usuario && p.Password == password)
                {
                    return p;
                }
            }
            return null;
        }

        public bool isRepetido(string usuario, string password)
        {
            foreach (var p in usuarios)
            {
                if (p.Usuario == usuario || p.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public void addAlumno(AlumnoModel nuevo)
        {
            usuarios.Add(nuevo);
        }

        public bool cambiarPassword(string email, string password)
        {
            foreach(var p in usuarios)
            {
                if (p.Email == email)
                {
                    p.Password = password;
                    return true;
                }
            }
            return false;
        }
    }
}
