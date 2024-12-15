using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using TallerWithLogin.Interfaces;
using TallerWithLogin.Models;

namespace TallerWithLogin.Services
{
    public class UsuariosService: IUsuariosService
    {
        private readonly List<UserModel> _usuarios;
        public UsuariosService() {
            _usuarios = new List<UserModel>
            {
                new OwnerModel
                {
                    isActivado = false,
                    Dni="Y4711918Z",
                    Name="Jared James Lloyd Bueno",
                    Email="jarofhanni@gmail.com",
                    Password="jared123456",
                    Phone="663663663",
                    Coches = new List<CocheModel>
                    {
                        new CocheModel
                        {
                            Matricula="0314JRD",
                            Marca="Mazda",
                            Modelo="RX-7",
                            MecanicosId=[333,123]
                        }
                    }
                },
                new MechanicModel
                {
                    Dni="41561936D",
                    Name="Aitor Tilla Crujiente",
                    Email="aitortilla@dawvroom.es",
                    Password="megustaeltaco",
                    Phone="696969696",
                    Id=333
                },
                new MechanicModel
                {
                    Dni="12312312C",
                    Name="Juan Tu Tri",
                    Email="undotre@dawvroom.es",
                    Password="123123123",
                    Phone="696969696",
                    Id=123
                },
                new AdministradorModel()
                {
                    Email="admin@dawvroom.com",
                    Password="a12345678"
                }
            };
        }
        public List<UserModel> getUsuarios()
        {
            return _usuarios;
        }

        public UserModel isUsuario(string correo, string password)
        {
            foreach (UserModel user in _usuarios)
            {
                if (user.Email == correo && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
