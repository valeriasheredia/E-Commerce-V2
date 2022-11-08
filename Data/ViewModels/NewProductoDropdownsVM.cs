using E_Commerce_V2.Models;
using System.Collections.Generic;

namespace E_Commerce_V2.Data.ViewModels
{
    public class NewProductoDropdownsVM
    {
        public NewProductoDropdownsVM()
        {
            Caracteristicas = new List<Caracteristica>();
            Lineas = new List<Linea>();
        }
        public List<Caracteristica> Caracteristicas { get; set; }            
        public List<Linea> Lineas { get; set; }
    }
}

