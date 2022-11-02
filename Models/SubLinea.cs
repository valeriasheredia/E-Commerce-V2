using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_V2.Models
{
    public class SubLinea
    {
        [Key]
        public int Id { get; set; }       
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        //Linea
        public int LineaId { get; set; }
        [ForeignKey("LineaId")]
        public Linea Linea { get; set; }
    }
}
