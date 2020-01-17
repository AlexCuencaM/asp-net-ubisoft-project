using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public double PrecioTotal { get; set; }
        public int PersonaId { get; set; }
        public Persona Comprador { get; set; }
        public DateTime FechaFactura { get; set; }
        public List<ComprasProducto> ComprasProductos { get; set; }
    }
}
