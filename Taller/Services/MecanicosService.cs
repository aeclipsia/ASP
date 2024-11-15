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
                    FechaAlta = new DateTime(2012,05,12,11,15,37),
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
                    FechaAlta = new DateTime(2017,12,19,12,20,04),
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
                    FechaAlta = new DateTime(2020,03,06,09,01,03),
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
                    FechaAlta = new DateTime(2022,10,10,10,01,55),
                    FotoMecanico = "/imagenes/mec4.jpg"
                }
            };
        }
    }
}
