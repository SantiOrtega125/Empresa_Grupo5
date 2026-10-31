using System.ComponentModel.DataAnnotations;

namespace Empresa.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; } = "";

        [StringLength(60)]
        public string? Ubicacion { get; set; }

        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
    }
}
