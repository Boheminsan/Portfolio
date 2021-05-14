using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity {
    public class MenuItem {
        public int MenuItemId { get; set; }

        [Required]
        [StringLength (20, ErrorMessage = "20 karakterden uzun isim girdiniz.")]
        public string MenuItemName { get; set; }

        [Required]
        [StringLength (50, ErrorMessage = "50 karakterden uzun link girdiniz.")]

        public string Link { get; set; }
        public List<SubMenu> SubMenus { get; set; }
    }
}