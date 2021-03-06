﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace Ubisoft.Models
{
    public class UbisoftContext:DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<ComprasProducto> ComprasProductos { get; set; }
        public DbSet<Caracteristica> Caractersisticas { get; set; }
        public DbSet<ProductoConCaracteristica> ProductoConCaracteristicas { get; set; }


        public UbisoftContext(DbContextOptions<UbisoftContext> dbContext): base(dbContext) { }       
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            var personas = CargarPersonas();
            var compras = CargarCompras(personas.ToList().First());

            var productos = CargarProductos();
            var productoCompra = CargarComprasProductos(productos.ToList().GetRange(2, 3), compras.ToList());
            var f = CargarCaractersisticas();
            var product = CargarProductoConCaracteristicas(productos.ToList().GetRange(2, 3));

            model.Entity<Producto>().HasData(CargarProductos().ToArray()) ;            
            model.Entity<Persona>().HasData(personas.ToArray());

            model.Entity<Compra>().HasData(compras.ToArray());

            model.Entity<ComprasProducto>().HasData(productoCompra.ToArray());
            model.Entity<Caracteristica>().HasData(f.ToArray());
            model.Entity<ProductoConCaracteristica>().HasData(product.ToArray());

        }
        private IEnumerable<Producto> CargarProductos()
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
                new Producto{Id=2, Titulo="IDEAL Laptop HP 17", Descripcion=descripcion2, Ruta=ruta2 },
                new Producto { Id = 3, Titulo = "Calculadora Gráfica HP Prime G2 2019",Precio= 215, Ruta = "/img/calculadora-grafica-hp-prime-solohpcom-01_2.jpg" },
                new Producto { Id = 4, Titulo = "Pendrive HP 16GB Modelo X750W", Ruta = "/img/pendrive-hp-x750w-16gb-solohpcom-01.jpg", Precio = 12 },
                new Producto { Id = 5, Titulo = "Pendrive HP 32GB Modelo X750W", Ruta = "/img/pendrive-hp-x750w-16gb-solohpcom-01.jpg", Precio = 22 },

            };
        }
        private IEnumerable<ComprasProducto> CargarComprasProductos(List<Producto> productos, List<Compra> compras)
        {            
            int cantidad = 5, i = 0;                         
            var lista = new List<ComprasProducto>();

            var experimento = from compra in compras from producto in productos
                select new ComprasProducto {
                    Id = ++i,
                    ProductoId = producto.Id,
                    CompraId = compra.Id,
                    Cantidad = cantidad,
                    PrecioProducto = producto.Precio * ++cantidad
                };
            return lista;
        }
        private IEnumerable<Compra> CargarCompras(Persona persona)
        {                  
            return new List<Compra>
            {
                new Compra(){Id = 1, FechaFactura = DateTime.Now, PersonaId = persona.Id},
                new Compra(){Id = 2, FechaFactura = DateTime.Now, PersonaId = persona.Id},
                new Compra(){Id = 3, FechaFactura = DateTime.Now, PersonaId = persona.Id}
            };
        }
        private IEnumerable<Persona> CargarPersonas()
        {
            return new List<Persona>
            {
                new Persona {Id = 1, Username = "AlexCuencaM", Contraseña = "ES SECRETO >:v" },
                new Persona {Id = 2, Username = "El Alex 8y9", Contraseña = "ES OTRO SECRETO >:v" },
                new Persona {Id = 3, Username = "IMySQL", Contraseña = "PASSWORD :D" }
            };
        }
        private IEnumerable<Caracteristica> CargarCaractersisticas()
        {
            int id = 1;
            List<string> features = new List<string>
            {
                { "Procesador: 528MHz" },{"RAM: 256MB +Rápida" },
                { "Almacenamiento: 512MB" }, { "Pantalla: Multi-táctil a Color(320 x 240px)" },
                {"Manual: Español" },{"Batería: Recargable" },{"Sistema Operativo: v14181" },
                {"USB 3.0" },{"IDEAL PARA LLAVERO" },{"VELOCIDAD de 70MB/s read" },{"VELOCIDAD de 10MB/s write" },
            };

            return from feature in features select 
                        new Caracteristica
                        {
                            Id = id++,
                            Descripcion = feature
                        };            
        }
        private IEnumerable<ProductoConCaracteristica> CargarProductoConCaracteristicas(List<Producto> listaProducto )
        {            
            var productos = new List<ProductoConCaracteristica>();
            int i = 1;            
            var features = new List<List<Caracteristica>> {
                CargarCaractersisticas().ToList().GetRange(0, 7),
                CargarCaractersisticas().ToList().GetRange(7, 4),
                CargarCaractersisticas().ToList().GetRange(7, 3),
            };            
            for (int _ = 0; _ < 3; _++)
                foreach (var item in features[_])                
                    productos.Add(new ProductoConCaracteristica { Id = i++, CaracteristicaId = item.Id, ProductoId = listaProducto[_].Id });                

            return productos;            
        }
    }
}
