using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBDDPelis.Models
{
    public class Generos
    {
        [Required]
        [Column("Genero")]
        [Key]
        public string Genero { get; set; }
    }
}
