using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Data.ViewModels;
using E_Commerce_V2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public class SubLineasService : EntityBaseRepository<SubLinea>, ISubLineasService
    {
        private readonly AppDbContext _context;

        //Constructor
        public SubLineasService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewSubLineaAsync(NewSubLineaVM data)
        {
            var newSubLinea = new SubLinea()
            {
                Nombre = data.Nombre,
                Descripcion = data.Descripcion,
                Imagen = data.Imagen,
                LineaId = data.LineaId
            };
            await _context.SubLineas.AddAsync(newSubLinea);
            await _context.SaveChangesAsync();
        }

        public async Task<NewSubLineaDropdownsVM> GetNewSubLineaDropdownsValues()
        {
            var response = new NewSubLineaDropdownsVM()
            {
                Lineas = await _context.Lineas.OrderBy(n => n.Nombre).ToListAsync()
            };
                 return response;
       
        }

        //public async Task<NewLineaDropdownsVM> GetNewLineaDropdownsValues()
        //{
        //    var response = new NewLineaDropdownsVM()
        //    {
        //        Lineas = await _context.Lineas.OrderBy(n => n.Nombre).ToListAsync()
        //    };
        //    return response;
        //}

        public async Task<SubLinea> GetSubLineaByIdAsync(int id)
        {
            var subLineaDetails = await _context.SubLineas
                .Include(n => n.Linea)
                .FirstOrDefaultAsync(n => n.Id == id);

            return subLineaDetails;
        }

        public async Task UpdateSubLineaAsync(NewSubLineaVM data)
        {
            var dbSubLinea = await _context.SubLineas.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbSubLinea != null)
            { 
                dbSubLinea.Nombre = data.Nombre;
                dbSubLinea.Descripcion = data.Descripcion;
                dbSubLinea.Imagen = data.Imagen;
                dbSubLinea.LineaId = data.LineaId;

                await _context.SaveChangesAsync();
            }
        }
    }
}
