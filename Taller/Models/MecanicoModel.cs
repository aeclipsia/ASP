namespace Taller.Models
{
    public class MecanicoModel:PersonaModel
    {
        public String Id { get; set; }
        public DateOnly FechaAlta { get; set; }
        public String FotoMecanico { get; set; }
    }
}
