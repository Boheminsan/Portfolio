using System.Collections.Generic;
using Portfolio.Entity;

namespace Portfolio.WebUI.Models {
    public class MenuSubMenuViewModel {
        public List<MenuItem> MenuItems { get; set; }
        public List<SubMenu> SubMenus { get; set; }
    }
}