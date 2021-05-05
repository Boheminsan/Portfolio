namespace Portfolio.Entity {
    public class SubMenu {
        public int SubMenuId { get; set; }
        public string SubMenuName { get; set; }
        public string Link { get; set; }
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}