using System.ComponentModel.DataAnnotations;

namespace P3_Ejercicio5.Models
{
    public class Alumno
    {

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [RegularExpression("[0-9]{8}[A-Z]", ErrorMessage = "DNI formato incorrecto")]
        public string? DNI { get; set; }

        
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Nombre { get;set;}

       
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Apellidos { get;set;}

       
        [RegularExpression("[6,9]{1}[0-9]{8}",ErrorMessage ="Teléfono formato incorrecto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Telefono { get;set;}

       
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Curso { get;set;}


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(18,70,ErrorMessage="El campo {0} debe ser un entero entre {1} - {2}")]
        public int? Edad { get;set;}

    }
}
