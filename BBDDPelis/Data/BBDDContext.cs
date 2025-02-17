using BBDDPelis.Models;
using Microsoft.EntityFrameworkCore;

namespace BBDDPelis.Data
{
    public class BBDDContext:DbContext
    {
        public BBDDContext(DbContextOptions<BBDDContext> options) : base(options) { }
        public DbSet<Generos> generos { get; set; }
        public DbSet<Info> info { get; set; }
        public DbSet<Peliculas> peliculas { get; set; }
    }
}
