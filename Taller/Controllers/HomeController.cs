using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Taller.Interfaces;
using Taller.Models;

namespace Taller.Controllers
{
    public class HomeController : Controller
    {

        /*Taller con mec�nicos[], coches[], (arreglos[]), nombre, direci�n, tel�fono*/
        /*Mec�nico con (id), nombre, apellidos, DNI, fecha alta, email, tel�fono, foto*/
        /*Coche con modelo, matr�cula, marca, a�o, due�o[], foto*/
        /*Due�o con nombre apellidos, dni, direccion[], email, telefono*/
        /*Direccion con calle, n�mero, codigo postal, provincia, poblaci�n*/
        /*(Arreglos con matricula, id, fecha entrada, fecha salida)*/

        /*Landing page con datos del taller: fotos*/
        /*Navbar con mec�nicos, coches, (arreglos)*/

        /*Controlador para home, mec�nicos, coches, (arreglos)*/

        private readonly ITaller data;
        public HomeController(ITaller source)
        {
            this.data = source;
        }

        public IActionResult Index()
        {
            TallerModel t = new()
            {
                TallerNombre = this.data.GetTaller().TallerNombre,
                TallerDir = this.data.GetTaller().TallerDir,
                TallerTel = this.data.GetTaller().TallerTel,
            };

            return View(t);
        }
    }
}
