using System;
using System.ComponentModel.DataAnnotations;

namespace Calificaciones.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
       
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre { get; set; }
       
        [MaxLength(120)]
        [Required(ErrorMessage = "El campo Apellidos es requerido")]
        public string Apellidos { get; set; }
        
        [MaxLength(4)]        
        [Required(ErrorMessage = "El campo Tipo de documento es requerido")]
        [Display(Name = "Tipo de Documento")]
        public string TipoDocumento { get; set; }
                     
        [Required(ErrorMessage = "El campo Documento es requerido")]
        public int Documento { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        
        [Required(ErrorMessage = "El campo E-mail es requerido")]
        [Display(Name = "E-mail")]        
        public string Email { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "El campo Dirección es requerido")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es requerido")]
        [Display(Name = "Teléfono")]        
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El campo Estado es requerido")]
        public bool Estado { get; set; }
        
    }
}