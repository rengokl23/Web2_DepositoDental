using System.ComponentModel.DataAnnotations;

namespace DepositoDental.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un producto")]
        public int ProductoId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que cero")]
        public int Cantidad { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio unitario debe ser mayor que cero")]
        public decimal PrecioUnitario { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una venta")]
        public int VentaId { get; set; }

        public Producto Producto { get; set; }
        public Venta Venta { get; set; }
    }
}
