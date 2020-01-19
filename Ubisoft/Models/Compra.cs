using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class Compra
    {
        public int Id { get; set; }        
        public DateTime FechaFactura { get; set; }
        public int PersonaId { get; set; }

        public virtual Persona Comprador { get; set; }        
        public virtual List<ComprasProducto> ComprasProductos { get; set; }
    }
}
