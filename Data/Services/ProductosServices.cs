using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Models;

namespace E_Commerce_V2.Data.Services
{
    public class ProductosServices : EntityBaseRepository<Producto>, IProductosService
    {
        public ProductosServices(AppDbContext context): base(context)
        {
        }
    }
}
