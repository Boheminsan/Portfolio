using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Concrete.EFCore;
using System.Linq;

namespace Portfolio.WebUI.Models.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly PortfolioContext context;
        public MenuViewComponent(PortfolioContext _context)
        {
            context = _context;
        }

        public IViewComponentResult Invoke()
        {
            var menus = context.MenuItems.Include(p => p.SubMenus).ToList();
            var subs = context.SubMenus.Include(s => s.MenuItem).ToList();
            var model = new MenuSubMenuViewModel
            {
                MenuItems = menus,
                SubMenus = subs,
            };
            return View(model);
        }
    }
}