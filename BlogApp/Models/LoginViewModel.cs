using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class LoginViewModel{

        [Required]
        [EmailAddress]
        [Display(Name = "Eposta")]
        public string? Email {get;set;}

        [Required]
        [StringLength(10, ErrorMessage ="Mak. 10 karakter belirtiniz.", MinimumLength =6)]
        [DataType(DataType.Password)]
         [Display(Name = "Parola")]
        public string? Password {get; set;}
    }
}