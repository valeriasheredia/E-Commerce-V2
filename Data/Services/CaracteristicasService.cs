using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Data.ViewModels;
using E_Commerce_V2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public class CaracteristicaServices : EntityBaseRepository<Caracteristica>, ICaracteristicasService
    {
        //public CaracteristicasService(AppDbContext context) : base(context)
        //{

        //}
        private readonly AppDbContext _context;
        public CaracteristicaServices(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async  Task<NewCaracteristicaDropdownsVM> GetNewCaracteristicaDropdownsValues()
        {
            var response = new NewCaracteristicaDropdownsVM();
            response.Caracteristicas = await _context.Caracteristicas.OrderBy(n => n.Nombre).ToListAsync();
            return response;
        }

    }
}
