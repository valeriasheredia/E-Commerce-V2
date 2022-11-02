using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_Commerce_V2.Data.Enums;

namespace E_Commerce_V2.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Código")]
        public string Codigo { get; set; }

        [Required]
        [Display(Name = "Producto")]
        public string Nombre { get; set; }
        public string Descripcion1 { get; set; }
        public string Contenido { get; set; }

        [Required]
        [Display(Name = "Imagen")]
        public string Imagen1 { get; set; }
        public string Imagen2 { get; set; }
        public string Imagen3 { get; set; }

        [Required]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }

        [Required]
        [Display(Name = "Stock")]
        public int Stock { get; set; }
        public string Valoracion { get; set; }

        [Required]
        [Display(Name = "Categoría del Producto")]
        public CategoriaProducto CategoriaProducto { get; set; }

        //Caracteristica
        public int CaracteristicaId { get; set; }
        [ForeignKey("CaracteristicaId")]
        public Caracteristica Caracteristica { get; set; }

        //Linea
        public int LineaId { get; set; }
        [ForeignKey("LineaId")]
        public Linea Linea { get; set; }
    }
}
