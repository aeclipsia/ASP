using Microsoft.EntityFrameworkCore;
using Practica6.Data;
using Practica6.Models;
using Practica6.Repositories.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace Practica6.Repositories
{
    public class JobOfferRepository : IJobOfferRepository
    {
        private readonly AppDbContext _context;

        public JobOfferRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(JobOffer jobOffer)
        {
            _context.JobOffers.Add(jobOffer);

            await _context.SaveChangesAsync();
        }

        public async Task<JobOffer> GetJobOffersById(int id)
        {
            return await _context.JobOffers.FirstOrDefaultAsync(j => j.Id == id);
        }

        public async Task<List<JobOffer>> GetJobOffersByCategoryId(int id)
        {
            return await _context.JobOffers.Where(j => j.CategoryId == id).ToListAsync();
        }

        public async Task Delete(JobOffer jobOffer)
        {
            _context.JobOffers.Remove(jobOffer);
            await _context.SaveChangesAsync();
        }
    }
}