using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity
{
    public class Service
    {
        public int ServiceId { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "20 karakterden uzun başlık girdiniz.")]
        public string Title { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Servis metni 150 karakterden uzun olamaz.")]
        public string Text { get; set; }
        public bool isHome { get; set; }
    }
}