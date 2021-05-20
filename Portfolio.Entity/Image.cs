namespace Portfolio.Entity
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public string FullPath { get; set; }
        public Project Project { get; set; }
        public Service Service { get; set; }
        public Slider Slider { get; set; }
        public Testimonial Testimonial { get; set; }
    }
}