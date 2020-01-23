using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ubisoft.Models
{
    public class Caracteristica
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 1;
        public string Descripcion { get; set; }
        public virtual List<ProductoConCaracteristica> ProductoConCaracteristicas { get; set; }
    }
}
