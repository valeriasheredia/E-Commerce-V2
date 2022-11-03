namespace E_Commerce_V2.Data.Services
{
    public class SubCaracteristicasService : ICaracteristicasService
    {
        private readonly AppDbContext _context;
        public SubCaracteristicasService(AppDbContext context)
        {
            _context = context;
        }
    }
}
