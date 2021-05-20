using Portfolio.Entity;
using System.Collections.Generic;

namespace Portfolio.Data.Concrete
{
    public class AdminSideBarRepository
    {
        private static readonly List<MenuItem> _sideMenuList = null;
        static AdminSideBarRepository()
        {
            _sideMenuList = new List<MenuItem>() {
                new MenuItem () { MenuItemId = 1, MenuItemName = "Kategoriler", Link = "Category" },
                new MenuItem () { MenuItemId = 2, MenuItemName = "Mesajlar", Link = "Contact" },
                new MenuItem () { MenuItemId = 3, MenuItemName = "Resimler", Link = "Image" },
                new MenuItem () { MenuItemId = 4, MenuItemName = "Slider", Link = "Slider" },
                new MenuItem () { MenuItemId = 5, MenuItemName = "Projeler", Link = "Project" },
                new MenuItem () { MenuItemId = 6, MenuItemName = "Menü", Link = "MenuItem" },
                new MenuItem () { MenuItemId = 7, MenuItemName = "AltMenü", Link = "SubMenu" },
                new MenuItem () { MenuItemId = 8, MenuItemName = "Servisler", Link = "Service" },
                new MenuItem () { MenuItemId = 9, MenuItemName = "Yorumlar", Link = "Testimonial" },
                new MenuItem () { MenuItemId = 10, MenuItemName = "Footer", Link = "Footer" },
            };
        }
        public static List<MenuItem> SideItems
        {
            get
            {
                return _sideMenuList;
            }
        }
    }
}