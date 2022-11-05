using E_Commerce_V2.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_V2.Models
{
    public class SubLinea : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="El nombre de la sub-línea es requerido")]
        [Display(Name = "Sub-Línea")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        //Linea
        [Required(ErrorMessage = "El nombre de la línea es requerido")]
        public int LineaId { get; set; }
        [ForeignKey("LineaId")]
        public Linea Linea { get; set; }
    }
}
