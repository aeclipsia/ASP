﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica5_1.Models
{
    public class Alumnos
    {
        [Required]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        [Required]
        [Column("DNI")]
        public string DNI { get; set; }
        [Required]
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Required]
        [Column("Apellidos")]
        public string Apellidos { get; set; }
        [Required]
        [Column("Ciclo")]
        public string Ciclo { get; set; }
        [Required]
        [Column("Telefono")]
        public string Telefono { get; set; }
        [Required]
        [Column("Edad")]
        public int Edad {  get; set; }
        [Required]
        [Column("Curso")]
        public int Curso { get; set; }
    }
}
