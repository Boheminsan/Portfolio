using System.Collections.Generic;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete {
    public class AdminSideBarRepository {
        private static readonly List<MenuItem> _sideMenuList = null;
        static AdminSideBarRepository () {
            _sideMenuList = new List<MenuItem> () {
                new MenuItem () { MenuItemId = 1, MenuItemName = "Anasayfa", Link = "Index" },
                new MenuItem () { MenuItemId = 2, MenuItemName = "Kategoriler", Link = "Category" },
                new MenuItem () { MenuItemId = 3, MenuItemName = "Mesajlar", Link = "Contact" },
                new MenuItem () { MenuItemId = 4, MenuItemName = "Resimler", Link = "Image" },
                new MenuItem () { MenuItemId = 5, MenuItemName = "Slider", Link = "Slider" },
                new MenuItem () { MenuItemId = 6, MenuItemName = "Projeler", Link = "Project" },
                new MenuItem () { MenuItemId = 7, MenuItemName = "Menü", Link = "MenuItem" },
                new MenuItem () { MenuItemId = 8, MenuItemName = "Servisler", Link = "Service" },
                new MenuItem () { MenuItemId = 9, MenuItemName = "Yorumlar", Link = "Testimonial" },
            };
        }
        public static List<MenuItem> SideItems {
            get {
                return _sideMenuList;
            }
        }
    }
}