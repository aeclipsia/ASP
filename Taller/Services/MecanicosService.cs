using Taller.Interfaces;
using Taller.Models;

namespace Taller.Services
{
    public class MecanicosService : IMecanicos
    {
        public List<MecanicoModel> getMecanicos()
        {
            return new List<MecanicoModel>()
            {
                new MecanicoModel()
                {
                    Nombre = "Maria",
                    Apellido = "Gamo",
                    Dni = "18298417A",
                    Correo = "mar.gamo@gmail.com",
                    Telefono = "667787654",
                    Id = "124A",
                    FechaAlta = DateTime.Now,
                    FotoMecanico = "/imagenes/mec2.jpg"
                },
                new MecanicoModel()
                {
                    Nombre = "Alberto",
                    Apellido = "Barbacid",
                    Dni = "16489321P",
                    Correo = "brbx@gmail.com",
                    Telefono = "667987454",
                    Id = "114A",
                    FechaAlta = DateTime.Now,
                    FotoMecanico = "/imagenes/mec1.jpg"
                },
                new MecanicoModel()
                {
                    Nombre = "Guillermo",
                    Apellido = "Cruz",
                    Dni = "18499417P",
                    Correo = "ggcruz@gmail.com",
                    Telefono = "663619651",
                    Id = "114A",
                    FechaAlta = DateTime.Now,
                    FotoMecanico = "/imagenes/mec3.jpg"
                },
                new MecanicoModel()
                {
                    Nombre = "Pedro",
                    Apellido = "Tovar",
                    Dni = "18499417P",
                    Correo = "pedro.tovar@gmail.com",
                    Telefono = "663860147",
                    Id = "114A",
                    FechaAlta = DateTime.Now,
                    FotoMecanico = "/imagenes/mec4.jpg"
                }
            };
        }
    }
}
