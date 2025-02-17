using BolsaTrabajo.Models;

namespace BolsaTrabajo.Interfaces
{
    public interface IUserService
    {
        public Task AddUser(User user);
        public Task<User> GetUserByEmail(string email);
        public int GetMaxUserID();
    }
}
