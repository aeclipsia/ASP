using Microsoft.EntityFrameworkCore;
using Practica6.Data;
using Practica6.Models;
using Practica6.Repositories.Interfaces;

namespace Practica6.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}