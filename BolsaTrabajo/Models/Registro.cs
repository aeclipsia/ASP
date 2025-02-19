namespace BolsaTrabajo.Models
{
    public class Registro
    {
        public int Id {  get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int JobOfferId { get; set; }
        public Oferta? JobOffer { get; set; }
    }
}
