using E_Commerce_V2.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_V2.Models
{
    public class NewSubLineaVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la sub-línea es requerido")]
        [Display(Name = "Sub-Línea")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción de la sub-línea es requerida")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        [Required(ErrorMessage = "Seleccione una línea")]
        public int LineaId { get; set; }
    }
}
