using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller.Interfaces;
using Taller.Models;

namespace Taller.Controllers
{
    public class CochesController : Controller
    {
        private readonly ICoches cars;

        public CochesController(ICoches cars)
        {
            this.cars = cars;
        }

        public ActionResult Coches()
        {
            List<CocheModel> coches = cars.getCoches();

            return View(coches);
        }
    }
}
