using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Data.ViewModels;
using E_Commerce_V2.Models;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public interface ISubLineasService : IEntityBaseRepository<SubLinea>
    {
        Task<SubLinea> GetSubLineaByIdAsync(int id);
        Task<NewSubLineaDropdownsVM> GetNewSubLineaDropdownsValues();
        Task AddNewSubLineaAsync(NewSubLineaVM data);
        Task UpdateSubLineaAsync(NewSubLineaVM data);
    }
}
