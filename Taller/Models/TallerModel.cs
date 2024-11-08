namespace Taller.Models
{
    public class TallerModel
    {
        public List<MecanicoModel> Mecanicos { get; set; }
        public List<CocheModel> Coches { get; set; }
        public String TallerNombre { get; set; }
        public DireccionModel TallerDir { get; set; }
        public String TallerTel {  get; set; }
    }
}
