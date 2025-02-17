using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BolsaTrabajo.Models
{
    public class User
    {
        [Required]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [Column("Name")]
        public required string Name { get; set; }
        [Required]
        [Column("Dni")]
        [MaxLength(9)]
        public required string Dni { get; set; }
        [Required]
        [Column("Email")]
        public required string Email { get; set; }
        [Column("Salt")]
        public string Salt { get; set; }
        [Required]
        [Column("Password")]
        public required byte[] Password { get; set; }
        [Required]
        [Column("Role")]
        public required Roles Role {  get; set; }

        public enum Roles
        {
            Administrador,
            Student
        }
    }
}
