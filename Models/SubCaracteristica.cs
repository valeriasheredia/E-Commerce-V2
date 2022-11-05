using E_Commerce_V2.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_V2.Models
{
    public class SubCaracteristica : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Sub-Característica")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }


        //Caracteristica

        [Required(ErrorMessage = "El nombre de la caracteristica es requerido")]
        public int CaracteristicaId { get; set; }
        [ForeignKey("CaracteristicaId")]
        public Caracteristica Caracteristica { get; set; }
    }
}
