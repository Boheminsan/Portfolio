namespace Portfolio.Entity
{
    public class Slider
    {
        public int SliderId { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public bool isHome { get; set; }
    }
}