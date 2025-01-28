using Microsoft.EntityFrameworkCore;
using Practica5_1.Models;

namespace Practica5_1.Data
{
    public class BBDDContext : DbContext
    {
        public BBDDContext(DbContextOptions<BBDDContext> options) : base(options) { }
        public DbSet<Ciclos> ciclos { get; set; }
        public DbSet<Alumnos> alumnos { get; set; }
        public DbSet<Cursos> cursos { get; set; }
    }
}
