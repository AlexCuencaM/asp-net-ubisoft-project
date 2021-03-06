﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class Persona
    {        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de Usuario es requerido :(")]
        [Display(Name = "Usuario")]
        public string Username { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida :(")]
        public string Contraseña { get; set; }

        public virtual List<Compra> Compras { get; set; }
    }
}
