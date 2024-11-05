using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Taller.Models;

namespace Taller.Controllers
{
    public class HomeController : Controller
    {

        /*Taller con mecánicos[], coches[], arreglos[], nombre, direción, teléfono*/
        /*Mecánico con (id), nombre, apellidos, DNI, fecha alta, email, teléfono, foto*/
        /*Coche con modelo, matrícula, marca, año, dueño[], foto*/
        /*Dueño con nombre apellidos, dni, direccion[], email, telefono*/
        /*Direccion con calle, número, codigo postal, provincia, población*/
        /*(Arreglos con matricula, id, fecha entrada, fecha salida)*/

        /*Landing page con datos del taller: fotos*/
        /*Navbar con mecánicos, coches, (arreglos)*/

        /*Controlador para home, mecánicos, coches, (arreglos)*/

        public HomeController(ILogger<HomeController> logger)
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
