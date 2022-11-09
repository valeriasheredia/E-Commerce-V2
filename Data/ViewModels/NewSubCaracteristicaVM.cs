using E_Commerce_V2.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_V2.Models
{
    public class NewSubCaracteristicaVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la sub-característica es requerido")]
        [Display(Name = "Sub-Característica")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción de la sub-característica es requerida")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        [Required(ErrorMessage = "Seleccione una característica")]
        public int CaracteristicaId { get; set; }
    }
}
