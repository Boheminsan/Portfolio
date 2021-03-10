using System.Collections.Generic;
using Portfolio.Entity;

namespace Portfolio.WebUI.Models {
    public class AdminViewModel {
        public List<Category> Categories { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Image> Images { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public List<Project> Projects { get; set; }
        public List<Service> Services { get; set; }
        public List<MenuItem> SideBar { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}