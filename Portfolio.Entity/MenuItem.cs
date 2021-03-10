namespace Portfolio.Entity {
    public class MenuItem {
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public string Link { get; set; }
        public int? ParentId { get; set; }
    }
}