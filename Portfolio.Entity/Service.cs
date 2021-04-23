namespace Portfolio.Entity {
    public class Service {
        public int ServiceId { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool isHome { get; set; }
    }
}