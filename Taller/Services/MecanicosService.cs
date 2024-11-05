using Taller.Models;

namespace Taller.Services
{
    public class MecanicosService
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
                    Id = "114A"
                },
            };
        }
    }
}
