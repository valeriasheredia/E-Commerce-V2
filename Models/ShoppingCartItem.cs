using System.ComponentModel.DataAnnotations;

namespace E_Commerce_V2.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
