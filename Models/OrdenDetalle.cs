using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_V2.Models
{
    public class OrdenDetalle
    {
        [Key]
        public int Id { get; set; }
        public int Monto { get; set; }
        public double Precio { get; set; }
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]

        public Producto Producto { get; set; }
        public int OrdenId { get; set; }
        [ForeignKey("OrdenId")]
        public Orden Orden { get; set; }
    }
}
