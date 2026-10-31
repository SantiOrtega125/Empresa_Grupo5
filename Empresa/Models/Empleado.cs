using System.ComponentModel.DataAnnotations;

namespace Empresa.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(150, ErrorMessage = "El nombre no puede ser mayor a 150 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "El cargo es obligatorio")]
        [StringLength(100, ErrorMessage = "El cargo no puede ser mayor a 100 caracteres")]
        public string Cargo { get; set; } = "";

        [Range(18, 70, ErrorMessage = "La edad debe estar entre 18 a 70")]
        [Display(Name = "Edad")]
        public int Edad { get; set; }

        [Display(Name = "Departamento")]
        public int DepartamentoId { get; set; }
        public Departamento? Departamento { get; set; }
    }
}
