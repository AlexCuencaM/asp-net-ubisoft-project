using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ubisoft.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ubisoft.Controllers
{
    public class TiendaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Producto> productos = cargarProducto();
            return View(productos);
        }
        private List<Producto> cargarProducto()
        {
            Producto a = new Producto { Titulo = "Calculadora Gráfica HP Prime G2 2019",Precio= 215, Ruta = "/img/calculadora-grafica-hp-prime-solohpcom-01_2.jpg" };
            //a.Features.Add("Procesador: 528MHz");
            //a.Features.Add("RAM: 256MB +Rápida");
            //a.Features.Add("Almacenamiento: 512MB");
            //a.Features.Add("Pantalla: Multi-táctil a Color(320 x 240px)");
            //a.Features.Add("Manual: Español");
            //a.Features.Add("Batería: Recargable");
            //a.Features.Add("Sistema Operativo: v14181");

            Producto b = new Producto { Titulo = "Pendrive HP 16GB Modelo X750W", Ruta = "/img/pendrive-hp-x750w-16gb-solohpcom-01.jpg", Precio = 12 };
            //b.Features.Add("USB 3.0");
            //b.Features.Add("IDEAL PARA LLAVERO");
            //b.Features.Add("VELOCIDAD de 70MB/s read");
            //b.Features.Add("VELOCIDAD de 10MB/s write");

            return new List<Producto> { a, b, b };
        }
    }
}
