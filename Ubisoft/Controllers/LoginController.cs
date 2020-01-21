using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ubisoft.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ubisoft.Controllers
{
    public class LoginController : BaseController
    {
        public LoginController(UbisoftContext context):base(context){ }
        // GET: /<controller>/        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Persona persona)
        {
            
            if(ModelState.IsValid)
            {                
                var personita = from p in Context.Personas
                                where p.Username.Equals(persona.Username) && p.Contraseña.Equals(persona.Contraseña)
                                select p;
                var test = personita.ToList().FirstOrDefault();
                if (test == null)
                {
                    ViewBag.error = "Datos ingresado de manera erronea o no registrado :c";
                    return View();
                }
                    
                return View("Index",test);
            }
            
            return View();            
        }
    }
}
