using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class PostCreateViewModel
    {
        public int PostId { get; set; }
        [Required]
        [Display(Name ="Başlık")]
        public string? Title {get;set;}

        [Required]
        [Display(Name ="Açıklama")]
        public string? Description {get;set;}

        [Required]
        [Display(Name ="içerik")]
        public string? Content {get;set;}

        [Required]
        [Display(Name ="Url")]
        public string? Url {get;set;}

        public bool IsActive {get;set;}


    }
}