using E_Commerce_V2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_Commerce_V2.Data.Carrito
{
    public class Carrito
    {
        public AppDbContext _context { get; set; }

        public string CarritoId { get; set; }

        public List<CarritoDetalle> carritoDetalles { get; set; }

        public Carrito(AppDbContext context)
        {
            _context = context;
        }

        public List<CarritoDetalle> GetCarritoDetalles()
        {
            return carritoDetalles ?? (carritoDetalles = _context.CarritoDetalles.Where(n => n.CarritoId == CarritoId).Include(n => n.Producto).ToList());
        }

        public double GetCarritoTotal() => (double)_context.CarritoDetalles.Where(n => n.CarritoId == CarritoId).Select(n => n.Producto.Precio * n.Monto).Sum();
           
        
    }
}
