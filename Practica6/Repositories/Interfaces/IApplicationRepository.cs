using Practica6.Models;

namespace Practica6.Repositories.Interfaces
{
    public interface IApplicationRepository
    {
        Task<List<JobOffer>> GetJobOffersByStudentId(int id);
        Task<Application> GetJobOffersByUserAndJobId(int offerJobId, int userId);
        Task<List<User>> GetUsersByJobOfferId(int id);
        Task Register(Application application);
    }
}
