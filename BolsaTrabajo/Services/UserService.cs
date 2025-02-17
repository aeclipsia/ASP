using BolsaTrabajo.Data;
using BolsaTrabajo.Models;
using BolsaTrabajo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BolsaTrabajo.Services
{
    public class UserService:IUserService
    {
        private readonly BolsaContext context;

        public UserService(BolsaContext context)
        {
            this.context = context;
        }

        public async Task AddUser(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public int GetMaxUserID()
        {
            if (this.context.Users.Count() == 0)
            {
                return 1;
            }
            else
            {
                return this.context.Users.Max(z=>z.Id)+1;
            }
        }
    }
}
