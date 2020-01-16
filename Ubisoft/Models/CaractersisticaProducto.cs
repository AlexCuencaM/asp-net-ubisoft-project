using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class CaractersisticaProducto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }        
        public Producto Producto { get; set; }

    }
}
