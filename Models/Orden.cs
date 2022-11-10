using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_V2.Models
{
    public class Orden
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }

        public List<OrdenDetalle> ordenDetalles { get; set; }
    }
}
