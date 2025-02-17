using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBDDPelis.Models
{
    public class Info
    {
        [Key]
        [Required]
        [Column("Titulo")]
        public string Titulo { get; set; }

        [Required]
        [Column("Director")]
        public string Director {  get; set; }

        [Required]
        [Column("Sinopsis")]
        public string Sinopsis { get; set; }

        [Column("Actor")]
        public string Actor { get; set; }

        [Column("Actriz")]
        public string Actriz {  get; set; }

    }
}
