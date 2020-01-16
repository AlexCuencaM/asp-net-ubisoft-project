using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Ubisoft.Models
{
    public class UbisoftContext:DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Compra> Compras { get; set; }

        public UbisoftContext(DbContextOptions<UbisoftContext> dbContext): base(dbContext) { }       
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            
            model.Entity<Producto>().HasData(CargarProductos().ToArray());
        }
        private List<Producto> CargarProductos()
        {
            var descripcion = "La revolucionaria HP Stream es una Mini Laptop elegante y asequible" +
                " basado en Windows que le permite almacenar el contenido en la nube para facilitar el acceso en más" +
                " lugares. Ver películas. Jugar. Realizar trabajos escolares o universitarios. Sea cual sea su necesidad, solo la" +
                " HP STREAM 11 te acompaña donde vayas. Con una gran pantalla ultra vívida HD, puedes ver cada detalle hasta el último píxel.";
            var ruta = "/img/laptop-hp-14-ideal-core-i5-7200u-8gb-ram-1tb-disco-solohpcom-00.jpg";

            var descripcion2 = "Ver películas.Hacer películas. Sea cual sea su pasión, nada trae a la" +
                " vida como la laptop HP Pavilion 14.Con una gran pantalla ultra vívida HD, puedes ver cada" +
                " detalle hasta el último píxel.Además te da un montón de almacenamiento y WebCam para disfrutar de toda la diversión.";
            var ruta2 = "/img/laptops-hp_9.jpg";
            return new List<Producto>()
            {

                new Producto{Id=1, Titulo ="SUPER Mini Laptop HP STREAM 11", Descripcion=descripcion,Ruta=ruta },
                new Producto{Id=2, Titulo="IDEAL Laptop HP 17", Descripcion=descripcion2, Ruta=ruta2},

            };
        }
    }
}
