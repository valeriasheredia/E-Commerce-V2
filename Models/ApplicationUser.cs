using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_V2.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name ="Nombre Completo")]
        public string Nombre { get; set; }
    }
}
