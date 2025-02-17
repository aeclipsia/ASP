namespace Practica6.Models
{
    public class Application
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int JobOfferId { get; set; }
        public JobOffer? JobOffer { get; set; }
    }
}