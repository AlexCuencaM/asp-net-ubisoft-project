using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ubisoft.Models;

namespace Ubisoft.Controllers
{
    public class HomeController : Controller
    {
        private readonly UbisoftContext context;
        public HomeController(UbisoftContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Producto> productos = context.Productos.ToList();
            return View(productos);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
