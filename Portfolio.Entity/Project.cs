using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity {
    public class Project {
        public int ProjectId { get; set; }
        public string CoverImage { get; set; }
        public List<Image> Images { get; set; }

        [Required]
        [StringLength (30, ErrorMessage = "20 karakterden uzun isim girdiniz.")]
        public string Title { get; set; }

        [Required]
        [StringLength (750, ErrorMessage = "Çok uzun bir metin girdiniz.")]
        public string Text { get; set; }
        public List<Category> Categories { get; set; }
        public bool isDone { get; set; }

    }
}