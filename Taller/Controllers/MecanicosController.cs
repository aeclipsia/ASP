using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller.Interfaces;
using Taller.Models;

namespace Taller.Controllers
{
    public class MecanicosController : Controller
    {

        private readonly IMecanicos mech;

        public MecanicosController(IMecanicos mech)
        {
            this.mech = mech;
        }
        public ActionResult Mecanicos()
        {
            List<MecanicoModel> mecs = mech.getMecanicos();

            return View(mecs);
        }
    }
}
