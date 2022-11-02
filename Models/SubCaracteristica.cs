using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_V2.Models
{
    public class SubCaracteristica
    {
        [Key]
        public int Id { get; set; }       
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }


        //Caracteristica
        public int CaracteristicaId { get; set; }
        [ForeignKey("CaracteristicaId")]
        public Caracteristica Caracteristica { get; set; }
    }
}
