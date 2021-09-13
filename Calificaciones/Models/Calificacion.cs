using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calificaciones.Models
{
    public class Calificacion
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("EstudianteId")]
        public Estudiante Estudiante { get; set; }
        
        [ForeignKey("CursoId")]
        public Curso Curso { get; set; }

        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
    }
}