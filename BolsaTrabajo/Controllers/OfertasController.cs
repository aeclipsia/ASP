using BolsaTrabajo.Interfaces;
using BolsaTrabajo.Models;
using Microsoft.AspNetCore.Mvc;

namespace BolsaTrabajo.Controllers
{
    public class OfertasController : Controller
    {
        private readonly IOfertaService ofertaService;

        public OfertasController(IOfertaService ofertaService)
        {
            this.ofertaService = ofertaService;
        }
        public async Task<IActionResult> Detail(int id)
        {
            List<Oferta> ofertas = await ofertaService.GetOfertasByCategory(id);
            return View(ofertas);
        }
    }
}
