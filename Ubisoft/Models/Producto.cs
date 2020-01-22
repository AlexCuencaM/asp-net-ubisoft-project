using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 1;
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Ruta { get; set; }
        public double Precio { get; set; }
        public virtual List<ComprasProducto> ComprasProductos { get; set; }

        //Puede ser opcional :D 
        //En ese caso, modificar la vista parcial ProductoTienda.cshtml        
        //public Producto() => Features = new List<string>();

    }
}
