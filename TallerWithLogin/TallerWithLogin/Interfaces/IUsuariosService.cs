using TallerWithLogin.Models;

namespace TallerWithLogin.Interfaces
{
    public interface IUsuariosService
    {
        public List<UserModel> getUsuarios();
        public UserModel isUsuario(string correo, string password);
    }
}
