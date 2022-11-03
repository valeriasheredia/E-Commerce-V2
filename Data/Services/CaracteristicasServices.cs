namespace E_Commerce_V2.Data.Services
{
    public class CaracteristicasServices : ICaracteristicasService
    {
        private readonly AppDbContext _context;
        public CaracteristicasServices(AppDbContext context)
        {
            _context = context;
        }
    }
}
