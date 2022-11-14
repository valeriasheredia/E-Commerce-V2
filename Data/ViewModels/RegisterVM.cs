using System.ComponentModel.DataAnnotations;

namespace E_Commerce_V2.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El Nombre es requerido")]
        public string Nombre { get; set; }

        [Display(Name ="Email")]
        [Required(ErrorMessage ="El Email es requerido")]
        public string EmailAddress { get; set; }


        [Display(Name = "Contraseña")]
        [Required(ErrorMessage ="La Contraseña es requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmar Contraseña")]
        [Required(ErrorMessage = "Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Las contraseñas no coinciden")]
        public string ConfirPassword { get; set; }
    }
}
