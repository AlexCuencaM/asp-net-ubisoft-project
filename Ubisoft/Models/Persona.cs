using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public virtual List<Compra> Compras { get; set; }
    }
}
