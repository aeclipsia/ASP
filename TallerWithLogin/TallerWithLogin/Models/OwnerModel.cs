namespace TallerWithLogin.Models
{
    public class OwnerModel:UserModel
    {
        public bool isActivado { get; set; }
        public List<CocheModel> Coches { get; set; }
    }
}
