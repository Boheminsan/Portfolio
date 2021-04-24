using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entity {
    public class Testimonial {
        public int TestimonialId { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool isHome { get; set; }
    }
}