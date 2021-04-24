using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class MenuItemController : Controller {

        private IMenuItemRepository repository;
        public MenuItemController (IMenuItemRepository _repo) {
            repository = _repo;
        }
        public IActionResult Index () {
            var model = repository.GetAll ().ToList ();
            return View (model);
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        public IActionResult Create (MenuItem model) {
            if (ModelState.IsValid) {
                MenuItem entity = new MenuItem () {
                    MenuItemName = model.MenuItemName,
                    Link = model.Link,
                    ParentId = model.ParentId //combobox?
                };
                repository.Add (entity);
                repository.Save ();
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpGet]
        public IActionResult Update (int id) {
            MenuItem entity = repository.GetById (id);
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (MenuItem model) {
            if (ModelState.IsValid) {
                MenuItem entity = repository.GetById (model.MenuItemId);
                entity.MenuItemName = model.MenuItemName;
                entity.Link = model.Link;
                entity.ParentId = model.ParentId; //combobox?
                repository.Save ();
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpPost]
        public IActionResult Delete (int MenuItemId) {
            MenuItem entity = repository.GetById (MenuItemId);
            if (entity != null) {
                repository.Delete (entity);
                repository.Save ();
            }
            return RedirectToAction ("Index");
        }
    }
}