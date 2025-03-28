using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace L01P02_2022GM650.Models
{
    public class departamentos
    {
        [Key]
        [DisplayName("ID de Departamento")]
        public int id { get; set; }

        [DisplayName("Nombre de Departamento")]
        [Required(ErrorMessage = "El nombre del departamento es requerido")]
        public string departamento { get; set; }
    }
}
