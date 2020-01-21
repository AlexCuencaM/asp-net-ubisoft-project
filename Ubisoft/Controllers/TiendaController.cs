using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ubisoft.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//Tipo de carga de datos relacionales(tabla transitiva) https://docs.microsoft.com/es-es/ef/ef6/querying/related-data
namespace Ubisoft.Controllers
{
    public class TiendaController : BaseController
    {
        public TiendaController(UbisoftContext context) : base(context) { }        
        public IActionResult Index()//Linkear una consulta de muchos a muchos 
        {         
            var productos = Context.ProductoConCaracteristicas;
            //Se tiene que modificar el contexto para cargar datos de manera diligente
            Context.Caractersisticas.Include(b => b.ProductoConCaracteristicas).ToList();
            Context.Productos.Include(b => b.ProductoConCaracteristicas).ToList().GetRange(2, 3);

            var query = from feature in productos
                        group feature by feature.Producto into detalles
                        select detalles;            
            return View(query);
        }        
    }
}
