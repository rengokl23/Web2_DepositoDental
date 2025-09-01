// Models/DetalleVenta.cs
using System.ComponentModel.DataAnnotations;

namespace DepositoDental.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un producto")]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        [Required(ErrorMessage = "Debe indicar la cantidad")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
        public int Cantidad { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser positivo")]
        public decimal PrecioUnitario { get; set; }

        [Required(ErrorMessage = "Debe seleccionar la venta")]
        public int VentaId { get; set; }
        public Venta Venta { get; set; }
    }
}
