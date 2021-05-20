using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "20 karakterden uzun isim girdiniz.")]
        public string Title { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "150 karakterden uzun isim girdiniz.")]
        public string Text { get; set; }
        public bool isHome { get; set; }
    }
}