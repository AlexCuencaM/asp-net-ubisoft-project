using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class ProductoConCaracteristica
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int CaractersisticaId { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Caractersistica Caractersistica { get; set; }
    }
}
