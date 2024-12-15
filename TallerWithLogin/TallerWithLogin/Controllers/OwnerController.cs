using Microsoft.AspNetCore.Mvc;

namespace TallerWithLogin.Controllers
{
    public class OwnerController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
