using System.Collections.Generic;
using Portfolio.Entity;

namespace Portfolio.WebUI.Models {
    public class ProjectImageViewModel {
        public List<Category> Categories { get; set; }
        public Project Project { get; set; }
        public List<Image> Images { get; set; }
    }
}