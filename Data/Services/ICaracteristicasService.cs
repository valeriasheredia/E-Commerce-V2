using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Data.ViewModels;
using E_Commerce_V2.Models;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public interface ICaracteristicasService : IEntityBaseRepository<Caracteristica>
    {
        Task<NewCaracteristicaDropdownsVM> GetNewCaracteristicaDropdownsValues();
    }
}
