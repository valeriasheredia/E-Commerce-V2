namespace E_Commerce_V2.Data.Services
{
    public class SubLineasService : ISubLineasService
    {
        private readonly AppDbContext _context;
        public SubLineasService(AppDbContext context)
        {
            _context = context;
        }
    }
}
