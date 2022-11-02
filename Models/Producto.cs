using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_Commerce_V2.Data.Enums;

namespace E_Commerce_V2.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }     
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion1 { get; set; }
        public string Contenido { get; set; }
        public string Imagen1 { get; set; }
        public string Imagen2 { get; set; }
        public string Imagen3 { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public int Stock { get; set; }
        public string Valoracion { get; set; }
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
