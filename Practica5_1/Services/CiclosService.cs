using Practica5_1.Data;
using Practica5_1.Interfaces;
using Practica5_1.Models;

namespace Practica5_1.Services
{
    public class CiclosService:ICiclosService
    {
        private BBDDContext _context;

        public CiclosService(BBDDContext context)
        {
            _context = context;
        }

        public List<Ciclos> GetCiclos() { 
            return this._context.ciclos.ToList();
        }

        public Ciclos FindCiclo(string siglas)
        {
            return this._context.ciclos.FirstOrDefault<Ciclos>(c => c.siglas == siglas);
        }
    }
}
