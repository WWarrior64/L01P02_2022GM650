using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace L01P02_2022GM650.Models
{
    public class materias
    {
        [Key]
        [DisplayName("ID de Materia")]
        public int id { get; set; }

        [DisplayName("Nombre de Materia")]
        [Required(ErrorMessage = "El nombre de la materia es requerido")]
        public string materia { get; set; }

        [DisplayName("Unidades Valorativas")]
        [Required(ErrorMessage = "Las unidades valorativas son requeridas")]
        public int unidades_valorativas { get; set; }

        [DisplayName("Estado")]
        [StringLength(1, ErrorMessage = "El estado debe ser un solo carácter")]
        public string? estado { get; set; }
    }
}
