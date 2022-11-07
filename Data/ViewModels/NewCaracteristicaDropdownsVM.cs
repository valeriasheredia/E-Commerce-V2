using E_Commerce_V2.Models;
using System.Collections.Generic;

namespace E_Commerce_V2.Data.ViewModels
{
    public class NewCaracteristicaDropdownsVM
    {

        public NewCaracteristicaDropdownsVM()
        {
            Caracteristicas = new List<Caracteristica>();
        }
        public List<Caracteristica> Caracteristicas { get; set; }
    }
}
