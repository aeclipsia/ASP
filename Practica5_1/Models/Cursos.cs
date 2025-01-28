using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica5_1.Models
{
    public class Cursos
    {
        [Required]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [Column("curso")]
        public int curso { get; set; }
        [Required]
        [Column("aula")]
        public string aula { get; set; }
        [Required]
        [Column("ciclo")]
        public string ciclo { get; set; }
    }
}
