using Microsoft.AspNetCore.Mvc;
using Practica6.Models;
using Practica6.Repositories.Interfaces;

namespace Practica6.Controllers
{
    public class JobOfferController : Controller
    {
        private readonly IJobOfferRepository _jobOfferRepository;

        public JobOfferController(IJobOfferRepository jobOfferRepository)
        {
            _jobOfferRepository = jobOfferRepository;
        }

        public async Task<IActionResult> Details(int id)
        {
            List<JobOffer> offers = await _jobOfferRepository.GetJobOffersByCategoryId(id);
            TempData["CategoryId"] = id;
            return View(offers);
        }

        public async Task<IActionResult> Create(JobOfferRegisterModel jobOfferRegisterModel)
        {
            JobOffer jobOffer = new JobOffer
            {
                Name = jobOfferRegisterModel.Name,
                Company = jobOfferRegisterModel.Company,
                Description = jobOfferRegisterModel.Description,
                CategoryId = jobOfferRegisterModel.CategoryId
            };

            await _jobOfferRepository.Create(jobOffer);

            return RedirectToAction("Home", "Home");
        }
    }
}