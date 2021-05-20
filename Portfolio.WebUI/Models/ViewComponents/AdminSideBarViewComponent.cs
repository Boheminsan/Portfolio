using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Concrete;
using System.Linq;

namespace Portfolio.WebUI.Models.ViewComponents
{
    public class AdminSideBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.Selected = RouteData.Values["controller"];
            var menuItems = AdminSideBarRepository.SideItems.ToList();
            return View(menuItems);
        }
    }
}