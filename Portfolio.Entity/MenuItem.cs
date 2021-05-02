namespace Portfolio.Entity {
    public class MenuItem {
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public string Link { get; set; }
        public int? ParentId { get; set; }
        public bool isParent { get; set; }
        public int Order { get; set; }
    }
}