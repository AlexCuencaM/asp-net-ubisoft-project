using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ubisoft.Models;

namespace Ubisoft.Controllers
{
    public class HomeController : BaseController
    {        
        public HomeController(UbisoftContext context) : base(context) { }        
        public IActionResult Index()
        {
            var productos = Context.Productos.ToList().GetRange(0,2);
            Context.SaveChanges();
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
