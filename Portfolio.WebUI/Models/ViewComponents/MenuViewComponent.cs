using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.WebUI.Models.ViewComponents {
    public class MenuViewComponent : ViewComponent {
        private IMenuItemRepository menuItem;
        public MenuViewComponent (IMenuItemRepository _menuItem) {
            menuItem = _menuItem;
        }
        public IViewComponentResult Invoke () {
            var menuItems = menuItem.GetAll ().ToList ();
            return View (menuItems);
        }
    }
}