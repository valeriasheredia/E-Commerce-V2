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
                            Nombre = " ",
                            Descripcion = " ",
                            Imagen = " "
                        },
                         new Linea()
                        {
                            Nombre = " ",
                            Descripcion = " ",
                            Imagen = " "
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
                            Nombre = " ",
                            Descripcion = " ",
                            Imagen = " "
                        },
                         new Caracteristica()
                        {
                            Nombre = " ",
                            Descripcion = " ",
                            Imagen = " "
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
                            Nombre = " ",
                            Descripcion = " ",
                            Imagen = " "
                        },
                         new SubLinea()
                        {
                             LineaId=2,
                            Nombre = " ",
                            Descripcion = " ",
                            Imagen = " "
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
                            Nombre = " ",
                            Descripcion = " ",
                            Imagen = " "
                        },
                         new SubCaracteristica()
                        {
                             CaracteristicaId = 2,
                            Nombre = " ",
                            Descripcion = " ",
                            Imagen = " "
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
                            Codigo= " ",
                            Nombre = " ",
                            Descripcion1 = " ",
                            Contenido=" ",
                            Imagen1 = " ",
                            Imagen2 = " ",
                            Imagen3 = " ",
                            Precio = 100,
                            Descuento= 0,
                            Stock = 10,
                            Valoracion= " ",
                            CategoriaProducto = CategoriaProducto.Clasico

                        },
                         new Producto()
                        {
                            CaracteristicaId = 2,
                            LineaId = 2,
                            Codigo= " ",
                            Nombre = " ",
                            Descripcion1 = " ",
                            Contenido=" ",
                            Imagen1 = " ",
                            Imagen2 = " ",
                            Imagen3 = " ",
                            Precio = 50,
                            Descuento = 30,
                            Stock = 50,
                            Valoracion= " ",
                            CategoriaProducto = CategoriaProducto.Clasico
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    } 
}
    
