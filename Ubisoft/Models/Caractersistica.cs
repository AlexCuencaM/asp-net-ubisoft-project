using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class Caractersistica
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public List<ProductoConCaracteristica> ProductoConCaracteristicas { get; set; }
    }
}
