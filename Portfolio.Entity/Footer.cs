using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity {
    public class Footer {
        public int FooterId { get; set; }

        [Required]
        [StringLength (20, ErrorMessage = "20 karakterden uzun isim girdiniz.")]
        public string SocialMediaName { get; set; }

        [Required]
        [StringLength (100, ErrorMessage = "100 karakterden uzun link girdiniz.")]
        public string Link { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }

    }
}