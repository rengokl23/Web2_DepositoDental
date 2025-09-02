using System.ComponentModel.DataAnnotations;

namespace DepositoDental.Models
{
    public class Producto
    {
        
        
            public int Id { get; set; }

            [Required(ErrorMessage = "El nombre es obligatorio")]
            public required string Nombre { get; set; }

            [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero")]
            public decimal Precio { get; set; }

            [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
            public int Stock { get; set; }

            [Required(ErrorMessage = "Debe seleccionar un proveedor")]
            public int ProveedorId { get; set; }

            public required Proveedor Proveedor { get; set; }
        

    }
}
