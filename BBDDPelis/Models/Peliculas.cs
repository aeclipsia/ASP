using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBDDPelis.Models
{
    public class Peliculas
    {
        [Key]
        [Required]
        [Column("Titulo")]
        public required string Titulo { get; set; }

        [Required]
        [Column("FechaEstreno")]
        public DateTime FechaEstreno { get; set; }

        [Required]
        [Column("Genero")]
        public required string Genero { get; set; }

        [Required]
        [Column("Precio")]
        public double Precio { get; set; }

        [Required]
        [Column("Imagen")]
        public required string Imagen {  get; set; }
    }
}
