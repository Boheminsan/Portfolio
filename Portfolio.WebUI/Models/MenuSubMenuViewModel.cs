using Portfolio.Entity;
using System.Collections.Generic;

namespace Portfolio.WebUI.Models
{
    public class MenuSubMenuViewModel
    {
        public List<MenuItem> MenuItems { get; set; }
        public List<SubMenu> SubMenus { get; set; }
    }
}