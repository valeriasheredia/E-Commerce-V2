using E_Commerce_V2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public interface ILineasService
    {
        Task<IEnumerable<Linea>> GetAllAsync();
        Task <Linea> GetByIdAsync(int id);
        Task AddAsync(Linea linea);
        Task <Linea> UpdateAsync(int id, Linea newLinea);
        Task DeleteAsync(int id);

    }
}
