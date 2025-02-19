namespace BolsaTrabajo.Models
{
    public class Oferta
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Categoria? Category { get; set; }
    }
}
