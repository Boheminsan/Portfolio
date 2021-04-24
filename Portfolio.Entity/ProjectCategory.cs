namespace Portfolio.Entity {
    public class ProjectCategory {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}