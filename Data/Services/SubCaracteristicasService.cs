using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Models;

namespace E_Commerce_V2.Data.Services
{
    public class SubCaracteristicasService : EntityBaseRepository<SubCaracteristica>, ISubCaracteristicasService
    {
        public SubCaracteristicasService(AppDbContext context) : base(context)
        {
        }
    }
}
