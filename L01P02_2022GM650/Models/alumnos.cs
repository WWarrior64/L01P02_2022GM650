using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2022GM650.Models
{
    public class alumnos
    {
        [Key]
        [DisplayName("ID de Alumno")]
        public int id { get; set; }

        [DisplayName("Código del Alumno")]
        [Required(ErrorMessage = "El código del alumno es requerido")]
        [StringLength(10, ErrorMessage ="El codigo del alumno no puede ser mayor a {1} caracteres")]
        public string codigo { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre del alumno es requerido")]
        [StringLength(50, ErrorMessage = "El nombre del alumno no puede ser mayor a {1} caracteres")]
        public string nombre { get; set; }

        [DisplayName("Apellidos")]
        [Required(ErrorMessage = "Los apellidos del alumno son requeridos")]
        [StringLength(50, ErrorMessage = "Los apellidos del alumno no pueden ser mayor a {1} caracteres")]
        public string apellidos { get; set; }

        [DisplayName("DUI")]
        [Required(ErrorMessage = "El DUI es requerido")]
        public int? dui { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "El estado del alumno es requerido")]
        public int? estado { get; set; }
    }
}
