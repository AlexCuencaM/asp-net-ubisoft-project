using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class ComprasProducto
    {       
        public Persona Persona { get; set; }
        public int Cantidad { get; set; }
        public double PrecioProducto { get; set; }
        //Puede ser opcional :D
        public List<Producto> Productos { get; set; }

    }
}
