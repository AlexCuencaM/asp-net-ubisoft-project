using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class Compra
    {
        public double PrecioTotal { get; set; }
        public Persona Comprador { get; set; }
        public DateTime FechaFactura { get; set; }
    }
}
