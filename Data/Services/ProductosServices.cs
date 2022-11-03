namespace E_Commerce_V2.Data.Services
{
    public class ProductosServices : IProductosService
    {
        private readonly AppDbContext _context;
        public ProductosServices(AppDbContext context)
        {
            _context = context;
        }
    }
}
