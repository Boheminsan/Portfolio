using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity {
    public class SubMenu {
        public int SubMenuId { get; set; }

        [Required]
        [StringLength (20, ErrorMessage = "20 karakterden uzun isim girdiniz.")]
        public string SubMenuName { get; set; }

        [Required]
        [StringLength (50, ErrorMessage = "50 karakterden uzun link girdiniz.")]
        public string Link { get; set; }
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}