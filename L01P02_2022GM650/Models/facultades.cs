using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace L01P02_2022GM650.Models
{
    public class facultades
    {
        [Key]
        [DisplayName("ID de Facultad")]
        public int id { get; set; }

        [DisplayName("Nombre de Facultad")]
        [Required(ErrorMessage = "El nombre de la facultad es requerido")]
        public string facultad { get; set; }
    }
}
