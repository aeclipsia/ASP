using Taller.Interfaces;
using Taller.Models;

namespace Taller.Services
{
    public class TallerService : ITaller
    {
        public TallerModel GetTaller()
        {
            return new TallerModel() {
                TallerNombre = "DAWvroom",
                TallerDir = new DireccionModel()
                {
                    Calle = "Bravo Murillo",
                    Numero = "30",
                    Zip = "28042",
                    Provincia = "Madrid",
                    Poblacion = "Madrid"
                },
                TallerTel = "666123456"
            };
        }
    }
}
