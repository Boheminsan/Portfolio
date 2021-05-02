using System.Collections.Generic;

namespace Portfolio.Entity {
    public class Project {
        public int ProjectId { get; set; }
        public string CoverImage { get; set; }
        public List<Image> Images { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<Category> Categories { get; set; }
        public bool isDone { get; set; }

    }
}