using Practica5_1.Data;
using Practica5_1.Interfaces;
using Practica5_1.Models;

namespace Practica5_1.Services
{
    public class AlumnosService:IAlumnosService
    {
        private BBDDContext _context;

        public AlumnosService(BBDDContext context)
        {
            _context = context;
        }

        public List<Alumnos> FindAlumnos(string siglas)
        {
            return this._context.alumnos.Where<Alumnos>(a=>a.Ciclo==siglas).ToList();
        }

        public Alumnos FindAlumno(string DNI)
        {
            return this._context.alumnos.FirstOrDefault<Alumnos>(a => a.DNI == DNI);
        }

        public async Task addAlumnos(Alumnos a)
        {
            this._context.alumnos.Add(a);
            await this._context.SaveChangesAsync();
        }
    }
}
