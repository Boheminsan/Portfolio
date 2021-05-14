using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Data.Concrete.EFCore;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class SubMenuController : Controller {
        private readonly PortfolioContext context;
        public SubMenuController (PortfolioContext _context) {
            context = _context;
        }
        public IActionResult Index () {
            var model = context.SubMenus.ToList ();
            return View (model);
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        public IActionResult Create (SubMenu model) {
            try {
                if (ModelState.IsValid) {
                    SubMenu entity = new SubMenu () {
                        SubMenuName = model.SubMenuName,
                        Link = model.Link,
                        MenuItemId = model.MenuItemId
                    };
                    context.SubMenus.Add (entity);
                    context.SaveChanges ();
                    return RedirectToAction ("Index");
                }
            } catch (System.Exception) {
                ViewBag.Message = "Olmayan üst menüye alt menü eklenemez.";
                return View ();
            }
            return View (model);
        }

        [HttpGet]
        public IActionResult Update (int id) {
            SubMenu entity = context.SubMenus.FirstOrDefault (m => m.SubMenuId == id);
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (SubMenu model) {
            if (ModelState.IsValid) {
                SubMenu entity = context.SubMenus.FirstOrDefault (m => m.SubMenuId == model.SubMenuId);
                entity.SubMenuName = model.SubMenuName;
                entity.Link = model.Link;
                entity.MenuItemId = model.MenuItemId;
                context.SubMenus.Update (entity);
                context.SaveChanges ();
                return RedirectToAction ("Index");
            }
            return View (model);
        }

        [HttpPost]
        public IActionResult Delete (int SubMenuId) {
            SubMenu entity = context.SubMenus.FirstOrDefault (m => m.SubMenuId == SubMenuId);
            if (entity != null) {
                context.SubMenus.Remove (entity);
                context.SaveChanges ();
            }
            return RedirectToAction ("Index");
        }
    }
}