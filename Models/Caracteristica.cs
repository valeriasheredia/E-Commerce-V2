using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_V2.Models
{
    public class Caracteristica
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }


        //Relationships
        public List<SubCaracteristica> SubCaracteristicas { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
