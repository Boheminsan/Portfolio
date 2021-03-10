using System.Collections.Generic;
using Portfolio.Entity;

namespace Portfolio.WebUI.Models {
    public class ProjectCategoryViewModel {
        public List<Category> Categories { get; set; }
        public List<Project> Projects { get; set; }
        public List<Image> Images { get; set; }
    }
}