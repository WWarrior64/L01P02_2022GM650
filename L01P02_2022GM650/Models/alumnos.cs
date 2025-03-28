using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2022GM650.Models
{
    public class alumnos
    {
        [Key]
        [DisplayName("ID de Alumno")]
        public int id { get; set; }

        [DisplayName("Código de Alumno")]
        [Required(ErrorMessage = "El código del alumno es requerido")]
        public string codigo { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre del alumno es requerido")]
        public string nombre { get; set; }

        [DisplayName("Apellidos")]
        [Required(ErrorMessage = "Los apellidos del alumno son requeridos")]
        public string apellidos { get; set; }

        [DisplayName("DUI")]
        [Required(ErrorMessage = "El DUI es requerido")]
        public string dui { get; set; }

        [DisplayName("Estado")]
        public int? estado { get; set; }
    }
}
