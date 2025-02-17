using Practica6.Models;

namespace Practica6.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task AddUser(User student);
        Task<User> GetUserByEmail(string email);
        Task Delete(List<User> users);
        Task<List<User>> GetStudents();
    }
}