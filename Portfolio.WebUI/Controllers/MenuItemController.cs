using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Concrete.EFCore;
using Portfolio.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.WebUI.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly PortfolioContext context;
        public MenuItemController(PortfolioContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var model = context.MenuItems.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Subs = context.SubMenus.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(MenuItem model, int[] subIds)
        {
            if (ModelState.IsValid)
            {
                if (subIds != null)
                {
                    List<SubMenu> subMenu = subIds.Select(id => context.SubMenus.FirstOrDefault(s => s.SubMenuId == id)).ToList();
                    MenuItem entity = new MenuItem()
                    {
                        MenuItemName = model.MenuItemName,
                        Link = model.Link,
                        SubMenus = subMenu
                    };
                    context.MenuItems.Add(entity);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            MenuItem entity = context.MenuItems.FirstOrDefault(m => m.MenuItemId == id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update(MenuItem model)
        {
            if (ModelState.IsValid)
            {
                MenuItem entity = context.MenuItems.Include(s => s.SubMenus).FirstOrDefault(m => m.MenuItemId == model.MenuItemId);
                List<SubMenu> sub = context.SubMenus.Where(s => s.MenuItemId == entity.MenuItemId).ToList();
                if (sub.Count == 0)
                {
                    entity.Link = model.Link;
                }
                else
                {
                    entity.Link = "#";
                    entity.SubMenus = sub;
                }
                entity.MenuItemName = model.MenuItemName;
                context.MenuItems.Update(entity);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int MenuItemId)
        {
            MenuItem entity = context.MenuItems.FirstOrDefault(m => m.MenuItemId == MenuItemId);
            if (entity != null)
            {
                context.MenuItems.Remove(entity);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}