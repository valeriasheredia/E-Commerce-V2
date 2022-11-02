using E_Commerce_V2.Data.Enums;
using E_Commerce_V2.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace E_Commerce_V2.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Linea
                if (!context.Lineas.Any())
                {
                    context.Lineas.AddRange(new List<Linea>()
                    {
                        new Linea()
                        {
                            Nombre = "Ekos",
                            Descripcion = "Sin descripcion",
                            Imagen = "https://i.pinimg.com/originals/a1/70/d2/a170d2dd32668d4e09c9077e9008daf1.jpg"
                        },
                         new Linea()
                        {
                            Nombre = "Plant",
                            Descripcion = "Sin descripcion",
                            Imagen = "https://i.pinimg.com/originals/72/b7/c6/72b7c6e8216bfc73c9471c400a191d87.png"
                        },
                    });
                    context.SaveChanges();
                }

                //Caracteristica
                if (!context.Caracteristicas.Any())
                {
                    context.Caracteristicas.AddRange(new List<Caracteristica>()
                    {
                        new Caracteristica()
                        {
                            Nombre = "Crema hidratante",
                            Descripcion = "Sin descripcion",
                            Imagen = "https://i.pinimg.com/originals/d6/f2/fb/d6f2fb8bd04ccc2077545cd1085202e2.jpg"
                        },
                         new Caracteristica()
                        {
                            Nombre = "Antiseñales",
                            Descripcion = "Sin descripcion",
                            Imagen = "https://i.pinimg.com/originals/d6/f2/fb/d6f2fb8bd04ccc2077545cd1085202e2.jpg"
                        },
                    });
                    context.SaveChanges();
                }

                //SubLinea
                if (!context.SubLineas.Any())
                    {
                        context.SubLineas.AddRange(new List<SubLinea>()
                    {
                        new SubLinea()
                        {
                            LineaId= 1,
                            Nombre = "Pitanga",
                            Descripcion = "Sin descripcion",
                            Imagen = "https://i.pinimg.com/originals/d7/0e/f3/d70ef3641b180ee791632f0dbba26884.jpg"
                        },
                         new SubLinea()
                        {
                             LineaId=2,
                            Nombre = "Chronos",
                            Descripcion = "Sin descripcion",
                            Imagen = "https://i.pinimg.com/originals/04/c8/59/04c8591611b9b3b01a3614797e3b4fd9.jpg"
                        },
                    });
                        context.SaveChanges();
                    }

                    //Subcaracteristica
                    if (!context.SubCaracteristicas.Any())
                    {
                        context.SubCaracteristicas.AddRange(new List<SubCaracteristica>()
                    {
                        new SubCaracteristica()
                        {
                            CaracteristicaId = 1,
                            Nombre = "Crema de manos ",
                            Descripcion = "Sin descripcion",
                            Imagen = "https://i.pinimg.com/originals/c1/1c/c9/c11cc94dd6be162b1877e81566983ba3.jpg"
                        },
                         new SubCaracteristica()
                        {
                             CaracteristicaId = 2,
                            Nombre = "Shampoo",
                            Descripcion = "Sin descripcion",
                            Imagen = "https://i.pinimg.com/originals/c6/5c/a0/c65ca030ba83df800988753f070bbf62.jpg"
                        },
                    });
                        context.SaveChanges();
                }

                //Producto

                if (!context.Productos.Any())
                        {
                            context.Productos.AddRange(new List<Producto>()
                    {
                        new Producto()
                        {
                            CaracteristicaId = 1,
                            LineaId=1,
                            Codigo= "Cod. 72997",
                            Nombre = "Jabones en Barra",
                            Descripcion1 = "Puro Vegetal Cremosos y Exfoliantes Ekos",
                            Contenido="4 unid.",
                            Imagen1 = "https://i.pinimg.com/originals/91/64/32/91643292f75d1bc4bbb320d68f745051.jpg",
                            Imagen2 = "https://i.pinimg.com/originals/ee/96/92/ee96921d301c2e834c3aa614249c3ec4.jpg",
                            Imagen3 = "https://i.pinimg.com/originals/c3/61/0f/c3610fd2d3b28c5dc8e20a1e93a6966a.jpg",
                            Precio = 1300,
                            Descuento= 0,
                            Stock = 10,
                            Valoracion= "5",
                            CategoriaProducto = CategoriaProducto.Clasico

                        },
                         new Producto()
                        {
                            CaracteristicaId = 2,
                            LineaId = 2,
                            Codigo= "Cod. 91849",
                            Nombre = "Acqua Biohidratante",
                            Descripcion1 = "Renovador Chronos",
                            Contenido="50 gr",
                            Imagen1 = "https://i.pinimg.com/originals/f8/78/58/f87858b7084f7330503e51fd2fd462e6.jpg",
                            Imagen2 = "https://i.pinimg.com/originals/6f/65/b8/6f65b8ed0e951fdc26d0a24c5cab95b3.jpg",
                            Imagen3 = "https://i.pinimg.com/originals/96/6b/9d/966b9d38f5ae9c0601aadab6697585f6.jpg",
                            Precio = 50,
                            Descuento = 30,
                            Stock = 50,
                            Valoracion= "5",
                            CategoriaProducto = CategoriaProducto.Clasico
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    } 
}
    
