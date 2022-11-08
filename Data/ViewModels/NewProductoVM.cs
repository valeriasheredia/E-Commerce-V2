using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_Commerce_V2.Data.Enums;
using E_Commerce_V2.Data.Base;

namespace E_Commerce_V2.Models
{
    public class NewProductoVM
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "El código del producto es requerido")]
        [Display(Name = "Código")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido")]
        [Display(Name = "Producto")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion1 { get; set; }

        [Required(ErrorMessage = "El contenido del producto es requerido")]
        [Display(Name = "Contenido")]
        public string Contenido { get; set; }

        [Required(ErrorMessage = "La imagen del producto es requerida")]
        [Display(Name = "Imagen1")]
        public string Imagen1 { get; set; }

        public string Imagen2 { get; set; }

        public string Imagen3 { get; set; }

        [Required(ErrorMessage = "El precio del producto es requerido")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        public decimal Descuento { get; set; }

        [Required(ErrorMessage = "El stock del producto es requerido")]
        [Display(Name = "Stock")]
        public int Stock { get; set; }

        public string Valoracion { get; set; }

        [Required(ErrorMessage = "La categoría del producto es requerida")]
        [Display(Name = "Selecciona una Categoría")]
        public CategoriaProducto CategoriaProducto { get; set; }

        [Required(ErrorMessage = "La característica del producto es requerida")]
        [Display(Name = "Selecciona una Característica")]
        public int CaracteristicaId { get; set; }

        [Required(ErrorMessage = "La línea del producto es requerida")]
        [Display(Name = "Selecciona una Línea")]
        public int LineaId { get; set; }
    }
}
