using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class CategoryController : Controller {
        private ICategoryRepository repository;
        public CategoryController (ICategoryRepository _repo) {
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
        public IActionResult Create (Category model) {
            if (ModelState.IsValid) {
                Category entity = new Category () {
                    CategoryName = model.CategoryName,
                    CType = model.CType,
                    Filter = model.Filter
                };
                repository.Add (entity);
                repository.Save ();
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpGet]
        public IActionResult Update (int id) {
            Category entity = repository.GetById (id);
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (Category model) {
            if (ModelState.IsValid) {
                Category entity = repository.GetById (model.CategoryId);
                entity.CategoryName = model.CategoryName;
                entity.CType = model.CType;
                entity.Filter = model.Filter;
                repository.Save ();
                ViewData["message"] = $"{entity.CategoryName} kaydedildi." + $"{DateTime.Now}";
                return RedirectToAction ("Index");
            }
            return View (model);
        }

        [HttpPost]
        public IActionResult Delete (int CategoryId) {
            Category entity = repository.GetById (CategoryId);
            if (entity != null) {
                repository.Delete (entity);
                repository.Save ();
            }
            return RedirectToAction ("Index");
        }
    }
}