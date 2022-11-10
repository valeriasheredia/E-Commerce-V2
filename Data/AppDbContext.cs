using E_Commerce_V2.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_V2.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Linea> Lineas { get; set; }
        public DbSet<SubLinea> SubLineas { get; set; }
        public DbSet<Caracteristica> Caracteristicas { get; set; }
        public DbSet<SubCaracteristica> SubCaracteristicas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<OrdenDetalle> OrdenDetalles { get; set; }
        public DbSet<CarritoDetalle> CarritoDetalles { get; set; }
    }
}
