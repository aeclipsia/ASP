using Microsoft.EntityFrameworkCore;
using Practica6.Models;

namespace Practica6.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}