using System.ComponentModel.DataAnnotations;

namespace ListadoAlumnos.Models
{
    public class AlumnoModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [RegularExpression("[0-9]{8}[A-Z]", ErrorMessage = "El formato del DNI es incorrecto")]
        public string? DNI { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Nombre { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Apellidos { get; set; }


        [RegularExpression("[6,9]{1}[0-9]{8}", ErrorMessage = "El formato del teléfono incorrecto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Telefono { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Curso { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(18, 70, ErrorMessage = "El campo {0} debe ser un entero entre {1} - {2}")]
        public int? Edad { get; set; }
    }
}
