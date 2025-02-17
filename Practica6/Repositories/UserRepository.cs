using Microsoft.EntityFrameworkCore;
using Practica6.Data;
using Practica6.Models;
using Practica6.Repositories.Interfaces;

namespace Practica6.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddUser(User student)
        {
            _context.Users.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(s => s.Email == email);
        }

        public async Task Delete(List<User> users)
        {
            foreach (var user in users) {
                _context.Users.Remove(user);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetStudents()
        {
            return await _context.Users.Where(s => s.UserType == User.Role.Student).ToListAsync();
        }
    }
}