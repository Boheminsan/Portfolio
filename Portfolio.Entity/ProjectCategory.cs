namespace Portfolio.Entity {
    public class ProjectCategory {
        public int CategoryId { get; set; }
        public Category CategoryName { get; set; }
        public int ProjectId { get; set; }
        public Project ProjectName { get; set; }
    }
}