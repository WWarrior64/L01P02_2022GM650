using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace L01P02_2022GM650.Models
{
    public class materias
    {
        [Key]
        [DisplayName("ID de la Materia")]
        public int id { get; set; }

        [DisplayName("Nombre de la Materia")]
        [Required(ErrorMessage = "El nombre de la materia es requerido")]
        [StringLength(100, ErrorMessage = "El nombre de la materia no puede ser mayor a {1} caracteres")]
        public string materia { get; set; }

        [DisplayName("Unidades Valorativas")]
        [Required(ErrorMessage = "Las unidades valorativas son requeridas")]
        public int unidades_valorativas { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "El estado de la materia es requerido")]
        [StringLength(1, ErrorMessage = "El estado debe ser un solo carácter")]
        public string? estado { get; set; }
    }
}
