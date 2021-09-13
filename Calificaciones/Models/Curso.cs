using System.ComponentModel.DataAnnotations;

namespace Calificaciones.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre del curso es requerido")]
        [MaxLength(120)]
        [Display(Name = "Nombre del curso")]
        public string NombreCurso { get; set; }

        [Required(ErrorMessage = "El campo Estado es requerido")]
        public bool Estado { get; set; }
    }
}