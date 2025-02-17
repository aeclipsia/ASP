using Microsoft.AspNetCore.Mvc;
using Practica6.Helpers;
using Practica6.Models;
using Practica6.Repositories.Interfaces;

namespace Practica6.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IJobOfferRepository _jobOfferRepository;
        private readonly IUserRepository _userRepository;

        public ApplicationController(IApplicationRepository applicationRepository, IJobOfferRepository jobOfferRepository, IUserRepository userRepository)
        {
            _applicationRepository = applicationRepository;
            _jobOfferRepository = jobOfferRepository;
            _userRepository = userRepository;
        }

        public async Task<IActionResult> StudentsJob(int id)
        {
            List<User> users = await _applicationRepository.GetUsersByJobOfferId(id);
            return View(users);
        }

        public async Task<IActionResult> Register(int id)
        {
            Application existApplicatoin = await _applicationRepository.GetJobOffersByUserAndJobId(id, HttpContext.Session.GetObject<User>("User").Id);

            if (existApplicatoin != null)
            {
                TempData["ErrorMessage"] = "Ya te has registrado para esta oferta, escoge otra";

                return RedirectToAction("Home", "Home");
            }

            Application application = new Application
            {
                JobOfferId = id,
                UserId = HttpContext.Session.GetObject<User>("User").Id
            };

            await _applicationRepository.Register(application);

            return RedirectToAction("Home", "Home");
        }

        public async Task<IActionResult> Delete(int id)
        {
            List<User> users = await _applicationRepository.GetUsersByJobOfferId(id);
            await _userRepository.Delete(users);

            JobOffer jobOffer = await _jobOfferRepository.GetJobOffersById(id);
            await _jobOfferRepository.Delete(jobOffer);

            return RedirectToAction("Home", "Home");
        }
    }
}