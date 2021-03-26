using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Data.Concrete;
using Portfolio.Entity;

namespace Portfolio.WebUI.Models.ViewComponents {
    public class AdminSideBarViewComponent : ViewComponent {
        public IViewComponentResult Invoke () {
            ViewBag.Selected = RouteData.Values["id"];
            var menuItems = AdminSideBarRepository.SideItems.ToList ();
            return View (menuItems);
        }
    }
}