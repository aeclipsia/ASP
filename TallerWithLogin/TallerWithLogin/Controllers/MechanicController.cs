using Microsoft.AspNetCore.Mvc;

namespace TallerWithLogin.Controllers
{
    public class MechanicController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
