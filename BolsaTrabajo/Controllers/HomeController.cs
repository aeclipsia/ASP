using BolsaTrabajo.Helpers;
using BolsaTrabajo.Interfaces;
using BolsaTrabajo.Models;
using Microsoft.AspNetCore.Mvc;

namespace BolsaTrabajo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService userService;

        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            User user = await userService.GetUserByEmail(loginModel.email);
            if (user == null)
            {
                TempData["ErrorMessage"] = "Usuario no encontrado";
                return RedirectToAction("Index");
            }
            else
            {
                byte[] pass = user.Password;
                string salt = user.Salt;
                byte[] tempPass = Cifrado.EncryptPassword(loginModel.password, salt);
                if (!Cifrado.CompareArrays(pass, tempPass))
                {
                    TempData["ErrorMessage"] = "Credenciales incorrectas";
                    return RedirectToAction("Index");
                }
            }
            HttpContext.Session.SetObject("User", user);
            return RedirectToAction("Categories");
        }

        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if(registerModel.Password.Length<8 || registerModel.Password.Length > 16)
            {
                TempData["ErrorMessage"] = "Contraseña debe ser entre 8 y 16 carácteres";
                return RedirectToAction("Index");
            }

            string SaltTemp = Cifrado.GenerateSalt();

            User user = new()
            {
                Id = userService.GetMaxUserID(),
                Name = registerModel.Name,
                Dni = registerModel.Dni,
                Email = registerModel.Email,
                Salt = SaltTemp,
                Password = Cifrado.EncryptPassword(registerModel.Password,SaltTemp),
                Role = registerModel.Role
            };

            await userService.AddUser(user);
            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Categories()
        {
            return View();
        }
    }
}
