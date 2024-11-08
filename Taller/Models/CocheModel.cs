namespace Taller.Models
{
    public class CocheModel
    {
        public String Modelo { get; set; }
        public String Matricula { get; set; }
        public String Marca { get; set; }
        public int Year { get; set; }
        public String ImagenCoche { get; set; }
        public OwnerModel Dueno { get; set; }
    }
}
