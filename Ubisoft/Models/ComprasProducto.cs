using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class ComprasProducto
    {
        public int Id { get; set; }
        public Compra Compra { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioProducto { get; set; }

    }
}
