using E_Commerce_V2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public class LineasService : ILineasService
    {

        private readonly AppDbContext _context;
        public LineasService(AppDbContext context)
        {
            _context = context;
        }


        public async Task AddAsync(Linea linea)
        {
           await _context.Lineas.AddAsync(linea);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Lineas.FirstOrDefaultAsync(n => n.Id == id);
            _context.Lineas.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Linea>> GetAllAsync()
        {
            var result =await _context.Lineas.ToListAsync();
            return result;
        }

        public async Task<Linea> GetByIdAsync(int id)
        {
            var result = await _context.Lineas.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Linea> UpdateAsync(int id, Linea newLinea)
        {
            _context.Update(newLinea);
            await _context.SaveChangesAsync();
            return newLinea;
        }

    }
}
