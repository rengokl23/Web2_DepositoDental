using System;
using System.ComponentModel.DataAnnotations;

namespace DepositoDental.Models
{
    public class Venta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un cliente")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public Cliente Cliente { get; set; }
    }
}
