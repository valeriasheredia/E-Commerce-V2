using E_Commerce_V2.Models;
using System.Collections.Generic;

namespace E_Commerce_V2.Data.ViewModels
{
    public class NewSubCaracteristicaDropdownsVM
    {

        public NewSubCaracteristicaDropdownsVM()
        {
            Caracteristicas = new List<Caracteristica>();
        }
        public List<Caracteristica> Caracteristicas { get; set; }
    }
}
