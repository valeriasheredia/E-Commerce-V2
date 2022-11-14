using System.ComponentModel.DataAnnotations;

namespace E_Commerce_V2.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name ="Email")]
        [Required(ErrorMessage ="El Email es requerido")]
        public string EmailAddress { get; set; }


        [Display(Name = "Contraseña")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
