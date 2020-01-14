using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class Producto
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Ruta { get; set; }
        public double Precio { get; set; } 
        //Puede ser opcional :D
        public List<CaractersisticaProducto> features { get; set; }

    }
}
