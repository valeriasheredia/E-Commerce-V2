using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_V2.Models
{
    public class Caracteristica
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public string Imagen { get; set; }


        //Relationships
        public List<SubCaracteristica> SubCaracteristicas { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
