using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Data.ViewModels;
using E_Commerce_V2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public class ProductosServices : EntityBaseRepository<Producto>, IProductosService
    {
        private readonly AppDbContext _context; 
        public ProductosServices(AppDbContext context): base(context)
        {
            _context = context;
        }

        public async Task AddNewProductoAsync(NewProductoVM data)
        {
            var newProducto = new Producto()
            {
                Codigo = data.Codigo,   
                Nombre = data.Nombre,
                Descripcion1 = data.Descripcion1,
                Contenido = data.Contenido,
                Imagen1= data.Imagen1,
                Imagen2= data.Imagen2,
                Imagen3 = data.Imagen3,
                Precio= data.Precio,
                Descuento= data.Descuento,
                Stock= data.Stock,
                Valoracion= data.Valoracion,
                CategoriaProducto= data.CategoriaProducto,
                CaracteristicaId= data.CaracteristicaId,    
                LineaId= data.LineaId
            };
            await _context.Productos.AddAsync(newProducto);
            await _context.SaveChangesAsync();
        }

        public async Task<NewProductoDropdownsVM> GetNewProductoDropdownsValues()
        {
            var response = new NewProductoDropdownsVM()
            {
                Caracteristicas = await _context.Caracteristicas.OrderBy(n => n.Nombre).ToListAsync(),
                Lineas = await _context.Lineas.OrderBy(n => n.Nombre).ToListAsync()
            };
           return response;
        }

        public async Task<Producto> GetProductoByIdAsync(int id)
        {
            var productoDetalle= await _context.Productos
                .Include(n => n.Linea)
                .Include(m => m.Caracteristica)
                .FirstOrDefaultAsync(x => x.Id == id);

            return productoDetalle;
        }

        public async Task UpdateProductoAsync(NewProductoVM data)
        {
            var dbProducto= await _context.Productos.FirstOrDefaultAsync(n =>n.Id == data.Id);

            if(dbProducto != null)
            {
                dbProducto.Codigo = data.Codigo;
                    dbProducto.Nombre = data.Nombre;
                dbProducto.Descripcion1 = data.Descripcion1;
                dbProducto.Contenido = data.Contenido;
                dbProducto.Imagen1 = data.Imagen1;
                dbProducto.Imagen2 = data.Imagen2;
                dbProducto.Imagen3 = data.Imagen3;
                dbProducto.Precio = data.Precio;
                dbProducto.Descuento = data.Descuento;
                dbProducto.Stock = data.Stock;
                dbProducto.Valoracion = data.Valoracion;
                dbProducto.CategoriaProducto = data.CategoriaProducto;
                dbProducto.CaracteristicaId = data.CaracteristicaId;
                dbProducto.LineaId = data.LineaId;

                await _context.SaveChangesAsync();
            }          
        }
    }
}
