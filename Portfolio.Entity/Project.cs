using System.Collections.Generic;

namespace Portfolio.Entity {
    public class Project {
        public int ProjectId { get; set; }
        // public List<Image> Images { get; set; } çoklu resim
        public string Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<ProjectCategory> ProjectCategories { get; set; }
        //bu amk migrationu bunu neden atlıyor
        public bool isDone { get; set; }
        public bool isHome { get; set; }

    }
}