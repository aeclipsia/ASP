using Microsoft.AspNetCore.Mvc;
using Practica6.Helpers;
using Practica6.Models;
using Practica6.Repositories.Interfaces;

namespace Practica6.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IApplicationRepository _applicationRepository;

        public HomeController(IUserRepository studentRepository, ICategoryRepository categoryRepository, IApplicationRepository applicationRepository)
        {
            _userRepository = studentRepository;
            _categoryRepository = categoryRepository;
            _applicationRepository = applicationRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Home()
        {
            List<Category> categories = await _categoryRepository.GetCategories();
            return View(categories);
        }

        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            User user = await _userRepository.GetUserByEmail(loginModel.Email);

            if (user == null)
            {
                TempData["ErrorMessage"] = "No se ha encontrado ningún usuario con esos datos";
                return RedirectToAction("Index");
            }
            else
            {
                byte[] saltBytes = user.Salt;
                byte[] encryptedPassword = Encryption.EncryptPassword(loginModel.Password, saltBytes);

                if (!Encryption.CompareArrays(user.Password, encryptedPassword))
                {
                    TempData["ErrorMessage"] = "Las credenciales son erróneas";
                    return RedirectToAction("Index");
                }
            }

            HttpContext.Session.SetObject("User", user);

            return RedirectToAction("Home");
        }

        public IActionResult FastLogin()
        {
            return RedirectToAction("Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            byte[] saltBytes = Encryption.GenerateSalt();
            byte[] encryptedPassword = Encryption.EncryptPassword(registerModel.Password, saltBytes);

            User newUser = new User
            {
                Name = registerModel.Name,
                Dni = registerModel.Dni,
                Email = registerModel.Email,
                Salt = saltBytes, 
                Password = encryptedPassword,
                UserType = registerModel.Role
            };

            await _userRepository.AddUser(newUser);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Create()
        {
            List<Category> categories = await _categoryRepository.GetCategories();
            return View(categories);
        }

        public async Task<IActionResult> Students()
        {
            List<User> students = await _userRepository.GetStudents();
            return View(students);
        }

        public async Task<IActionResult> StudentOffers(int id)
        {
            List<JobOffer> jobOffers = await _applicationRepository.GetJobOffersByStudentId(id);
            return View(jobOffers);
        }
    }
}