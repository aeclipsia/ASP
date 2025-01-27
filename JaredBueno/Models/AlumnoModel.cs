namespace JaredBueno.Models
{
    public class AlumnoModel:UsuarioModel
    {
        public EnumeradoCiclo Ciclo { get; set; }
        public int Curso { get; set; }
        public List<string>? Idiomas { get; set; }
        public string IdiomasString { get; set; }
    }
}
