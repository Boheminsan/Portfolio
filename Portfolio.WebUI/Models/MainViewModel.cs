using Portfolio.Entity;
using System.Collections.Generic;

namespace Portfolio.WebUI.Models
{
    public class MainViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Image> Images { get; set; }
        public List<Footer> Footers { get; set; }
    }
}