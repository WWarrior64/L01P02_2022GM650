using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace L01P02_2022GM650.Models
{
    public class departamentos
    {
        [Key]
        [DisplayName("ID del Departamento")]
        public int id { get; set; }

        [DisplayName("Nombre del Departamento")]
        [Required(ErrorMessage = "El nombre del departamento es requerido")]
        [StringLength(50, ErrorMessage = "El nombre del departamento no puede ser mayor a {1} caracteres")]
        public string departamento { get; set; }
    }
}
