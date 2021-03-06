﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ubisoft.Models
{
    public class ProductoConCaracteristica
    {        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int CaracteristicaId { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Caracteristica Caracteristica { get; set; }
    }
}
