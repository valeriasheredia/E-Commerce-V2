using E_Commerce_V2.Models;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace E_Commerce_V2.Data.ViewModels
{
    public class NewLineaDropdownsVM
    {

        public NewLineaDropdownsVM()
        {
            Lineas = new List<Linea>();
        }
        public List<Linea> Lineas{ get; set; }
    }
}
