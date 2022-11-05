using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_Commerce_V2.Data.Base;

namespace E_Commerce_V2.Models
{
    public class Caracteristica :IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la característica es requerido")]
        [Display(Name = "Característica")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="La característica debe tener mas de 3 letras")]
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
