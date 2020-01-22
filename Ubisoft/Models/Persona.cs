using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de Usuario es requerido hijo de puta xd")]
        [Display(Name = "Usuario")]
        public string Username { get; set; }
        [Required]
        public string Contraseña { get; set; }

        public virtual List<Compra> Compras { get; set; }
    }
}
