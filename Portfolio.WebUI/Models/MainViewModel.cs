using System.Collections.Generic;
using Portfolio.Entity;

namespace Portfolio.WebUI.Models {
    public class MainViewModel {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Image> Images { get; set; }
    }
}