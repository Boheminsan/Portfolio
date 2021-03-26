using System.Collections.Generic;

namespace Portfolio.Entity {
    public enum CategoryType {
        Lang = 1, Tech = 2
    }
    public class Category {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public CategoryType CType { get; set; }
        public string Filter { get; set; }
        public List<ProjectCategory> ProjectCategories { get; set; }

    }
}