// Models/Proveedor.cs
using System.ComponentModel.DataAnnotations;

namespace DepositoDental.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "Formato de teléfono inválido")]
        public string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Correo electrónico inválido")]
        public string Email { get; set; }
    }
}
