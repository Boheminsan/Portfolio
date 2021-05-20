using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "50 karakterden uzun isim girdiniz.")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Mail { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "50 karakterden uzun başlık girdiniz.")]

        public string Title { get; set; }

        [Required]
        [StringLength(750, ErrorMessage = "Bu çok uzun bir mesaj.")]
        public string Text { get; set; }
        public bool isRead { get; set; }

    }
}