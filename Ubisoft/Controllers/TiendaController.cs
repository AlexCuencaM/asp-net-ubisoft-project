using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ubisoft.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ubisoft.Controllers
{
    public class TiendaController : BaseController
    {
        public TiendaController(UbisoftContext context): base(context){}        
        // GET: /<controller>/
        public IActionResult Index()
        {
            var productos = Context.ProductoConCaracteristicas;
            return View(productos);
        }
        private List<Producto> cargarProducto()
        {
            
            return new List<Producto>
            {
                new Producto { Id = 1, Titulo = "Calculadora Gráfica HP Prime G2 2019",Precio= 215, Ruta = "/img/calculadora-grafica-hp-prime-solohpcom-01_2.jpg" },
                new Producto { Id = 2, Titulo = "Pendrive HP 16GB Modelo X750W", Ruta = "/img/pendrive-hp-x750w-16gb-solohpcom-01.jpg", Precio = 12 },
                new Producto { Id = 3, Titulo = "Pendrive HP 32GB Modelo X750W", Ruta = "/img/pendrive-hp-x750w-16gb-solohpcom-01.jpg", Precio = 22 },
            };
        }
    }
}
