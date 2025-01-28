using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practica5_1.Models
{
    [Table("Ciclos")]
    public class Ciclos
    {
        [Required]
        [Column("Codigo")]
        public required string codigo { get; set; }
        [Key]
        [Required]
        [Column("Siglas")]
        public required string siglas { get; set; }
        [Required]
        [Column("Nombre")]
        public required string nombre { get; set; }
        [Required]
        [Column("Cursos")]
        public required int cursos { get; set; }
    }
}
