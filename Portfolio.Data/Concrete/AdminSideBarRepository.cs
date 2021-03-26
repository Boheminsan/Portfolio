using System.Collections.Generic;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete {
    public class AdminSideBarRepository {
        private static readonly List<MenuItem> _sideMenuList = null;
        static AdminSideBarRepository () {
            _sideMenuList = new List<MenuItem> () {
                new MenuItem () { MenuItemId = 1, MenuItemName = "Category", Link = "#category" },
                new MenuItem () { MenuItemId = 2, MenuItemName = "Contact", Link = "#Contact" },
                new MenuItem () { MenuItemId = 3, MenuItemName = "Images", Link = "#Images" },
                new MenuItem () { MenuItemId = 4, MenuItemName = "Slider", Link = "#Slider" },
                new MenuItem () { MenuItemId = 5, MenuItemName = "Project", Link = "#Project" },
                new MenuItem () { MenuItemId = 6, MenuItemName = "Menu", Link = "#Link" },
                new MenuItem () { MenuItemId = 7, MenuItemName = "Service", Link = "#Service" },
                new MenuItem () { MenuItemId = 8, MenuItemName = "Testimonials", Link = "#Testimonials" },
            };
        }
        public static List<MenuItem> SideItems {
            get {
                return _sideMenuList;
            }
        }
    }
}