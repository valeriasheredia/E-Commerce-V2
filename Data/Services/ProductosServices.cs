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
    }
}
