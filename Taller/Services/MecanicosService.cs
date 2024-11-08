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
                    Nombre = "Pedro",
                    Apellido = "Tovar",
                    Dni = "18499417P",
                    Correo = "pedro.tovar@gmail.com",
                    Telefono = "667787654",
                    Id = "114A",
                    FechaAlta = DateTime.Now,
                    FotoMecanico = "/imagenes/mec1.jpg"
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
                    FotoMecanico = "/imagenes/mec2.jpg"
                },
                new MecanicoModel()
                {
                    Nombre = "Pedro",
                    Apellido = "Tovar",
                    Dni = "18499417P",
                    Correo = "pedro.tovar@gmail.com",
                    Telefono = "667787654",
                    Id = "114A",
                    FechaAlta = DateTime.Now,
                    FotoMecanico = "/imagenes/mec1.jpg"
                },
                new MecanicoModel()
                {
                    Nombre = "Pedro",
                    Apellido = "Tovar",
                    Dni = "18499417P",
                    Correo = "pedro.tovar@gmail.com",
                    Telefono = "667787654",
                    Id = "114A",
                    FechaAlta = DateTime.Now,
                    FotoMecanico = "/imagenes/mec1.jpg"
                }
            };
        }
    }
}
