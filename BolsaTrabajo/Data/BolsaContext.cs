using BolsaTrabajo.Models;
using Microsoft.EntityFrameworkCore;

namespace BolsaTrabajo.Data
{
    public class BolsaContext:DbContext
    {
        public BolsaContext(DbContextOptions<BolsaContext>options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<Registro> Registros { get; set; }
    }
}
