using Microsoft.AspNetCore.Mvc;

namespace TallerWithLogin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
