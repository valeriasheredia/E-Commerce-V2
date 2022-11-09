using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Data.ViewModels;
using E_Commerce_V2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public class SubCaracteristicasService : EntityBaseRepository<SubCaracteristica>, ISubCaracteristicasService
    {
        private readonly AppDbContext _context;
        public SubCaracteristicasService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewSubCaracteristicaAsync(NewSubCaracteristicaVM data)
        {
            var newSubCaracteristica = new SubCaracteristica()
            {
                Nombre = data.Nombre,
                Descripcion = data.Descripcion,
                Imagen = data.Imagen,
                CaracteristicaId = data.CaracteristicaId
            };
            await _context.SubCaracteristicas.AddAsync(newSubCaracteristica);
            await _context.SaveChangesAsync();  
        }

        public async Task<NewSubCaracteristicaDropdownsVM> GetNewSubCaracteristicaDropdownsValues()
        {
            var response = new NewSubCaracteristicaDropdownsVM()
            {
                Caracteristicas = await _context.Caracteristicas.OrderBy(n => n.Nombre).ToListAsync()
            };
            return response;
        }
        public async Task<SubCaracteristica> GetSubCaracteristicaByIdAsync(int id)
        {
            var subCaracteristicaDetails = await _context.SubCaracteristicas
                .Include(n => n.Caracteristica)
                .FirstOrDefaultAsync(n => n.Id == id);

            return subCaracteristicaDetails;
        }

     
        public async Task UpdateSubCaracteristicasAsync(NewSubCaracteristicaVM data)
        {
            var dbSubCaracteristica = await _context.SubCaracteristicas.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbSubCaracteristica != null)
            {
                dbSubCaracteristica.Nombre = data.Nombre;
                dbSubCaracteristica.Descripcion = data.Descripcion;
                dbSubCaracteristica.Imagen = data.Imagen;
                dbSubCaracteristica.CaracteristicaId = data.CaracteristicaId;

                await _context.SaveChangesAsync();
            }
        }
    }
}