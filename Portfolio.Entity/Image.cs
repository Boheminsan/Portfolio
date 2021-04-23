namespace Portfolio.Entity {
    public class Image {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public string Path { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}