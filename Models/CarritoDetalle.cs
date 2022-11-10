using System.ComponentModel.DataAnnotations;

namespace E_Commerce_V2.Models
{
    public class CarritoDetalle
    {
        [Key]
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public int Monto { get; set; }
        public string CarritoId { get; set; }
    }
}
