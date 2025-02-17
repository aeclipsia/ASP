using Microsoft.EntityFrameworkCore;
using Practica6.Data;
using Practica6.Models;
using Practica6.Repositories.Interfaces;

namespace Practica6.Repositories
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly AppDbContext _context;

        public ApplicationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Register(Application application)
        {
            _context.Applications.AddAsync(application);
            await _context.SaveChangesAsync();
        }

        public async Task<Application> GetJobOffersByUserAndJobId(int offerJobId, int userId)
        {
            return await _context.Applications.FirstOrDefaultAsync(a => a.JobOfferId == offerJobId && a.UserId == userId);
        }

        public async Task<List<User>> GetUsersByJobOfferId(int id)
        {
            return await _context.Applications.Where(a => a.JobOfferId == id).Select(a => a.User).ToListAsync();
        }

        public Task<List<JobOffer>> GetJobOffersByStudentId(int id)
        {
            return _context.Applications.Where(a => a.UserId == id).Select(a => a.JobOffer).ToListAsync();
        }
    }
}