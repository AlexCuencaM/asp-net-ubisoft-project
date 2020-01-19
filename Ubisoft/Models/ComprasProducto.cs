using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models 
{
    public class ComprasProducto //Para cargar el precio total se selecciona todos los productos donde el id de compra es el mismo
    {
        public int Id { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public double PrecioProducto { get; set; }

        public virtual Compra Compra { get; set; }
        public virtual Producto Producto { get; set; }
        

    }
}
