using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Models;

namespace E_Commerce_V2.Data.Services
{
    public class CaracteristicasService : EntityBaseRepository<Caracteristica>, ICaracteristicasSservice
    {
        public CaracteristicasService(AppDbContext context) : base(context)
        {

        }
    }
}
