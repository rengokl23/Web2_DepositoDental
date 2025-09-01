// Models/Venta.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DepositoDental.Models
{
    public class Venta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public ICollection<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();
    }
}
