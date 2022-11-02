using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_V2.Models
{
    public class Linea
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        //Relatioships
        public List<SubLinea> SubLineas { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
