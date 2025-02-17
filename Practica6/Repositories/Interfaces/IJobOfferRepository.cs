using Practica6.Models;

namespace Practica6.Repositories.Interfaces
{
    public interface IJobOfferRepository
    {
        Task Create(JobOffer jobOffer);
        Task<JobOffer> GetJobOffersById(int id);
        Task<List<JobOffer>> GetJobOffersByCategoryId(int id);
        Task Delete(JobOffer jobOffer);
    }
}