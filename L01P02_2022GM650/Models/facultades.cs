using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace L01P02_2022GM650.Models
{
    public class facultades
    {
        [Key]
        [DisplayName("ID de la Facultad")]
        public int id { get; set; }

        [DisplayName("Nombre de la Facultad")]
        [Required(ErrorMessage = "El nombre de la facultad es requerido")]
        [StringLength(100, ErrorMessage = "El nombre de la facultad no puede ser mayor a {1} caracteres")]
        public string facultad { get; set; }
    }
}
