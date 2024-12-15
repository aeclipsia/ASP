namespace TallerWithLogin.Models
{
    public class CocheModel
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<int> MecanicosId { get; set; }
    }
}
