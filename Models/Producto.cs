using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_Commerce_V2.Data.Enums;
using E_Commerce_V2.Data.Base;

namespace E_Commerce_V2.Models
{
    public class Producto : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El código del producto es requerido")]
        [Display(Name = "Código")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido")]
        [Display(Name = "Producto")]
        public string Nombre { get; set; }

        public string Descripcion1 { get; set; }

        [Required(ErrorMessage = "El contenido del producto es requerido")]
        public string Contenido { get; set; }

        [Required(ErrorMessage = "La imagen del producto es requerida")]
        [Display(Name = "Imagen")]
        public string Imagen1 { get; set; }

        public string Imagen2 { get; set; }

        public string Imagen3 { get; set; }

        [Required(ErrorMessage = "El precio del producto es requerido")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        public decimal Descuento { get; set; } = 0;

        [Required(ErrorMessage = "El stock del producto es requerido")]
        [Display(Name = "Stock")]
        public int Stock { get; set; }

        public string Valoracion { get; set; }

        [Required(ErrorMessage = "La categoría del producto es requerida")]
        [Display(Name = "Categoría del Producto")]
        public CategoriaProducto CategoriaProducto { get; set; }

        //Caracteristica
        public int CaracteristicaId { get; set; }
        [ForeignKey("CaracteristicaId")]
        [Required(ErrorMessage = "La característica del producto es requerida")]
        public Caracteristica Caracteristica { get; set; }

        //Linea

        [Required(ErrorMessage = "La línea del producto es requerida")]
        public int LineaId { get; set; }
        [ForeignKey("LineaId")]
        public Linea Linea { get; set; }
    }
}
