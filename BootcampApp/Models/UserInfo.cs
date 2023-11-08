using System.ComponentModel.DataAnnotations;

namespace BootcampApp.Models
{
    public class UserInfo{

        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alanı zorunludur.")]
        public string? Name { get; set; } //null
         [Required(ErrorMessage ="Telefon alanı zorunludur.")]
        public string? Phone { get; set; }
         [Required(ErrorMessage ="Email alanı zorunludur.")]
         [EmailAddress(ErrorMessage ="Hatalı Email")]
        public string? Email { get; set; }
         [Required(ErrorMessage ="Katılım durumu alanı zorunludur.")]
        public bool? WillAttend { get; set; } //true, false, null
    }
}