using System;
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
            return View ();
        }

        public IActionResult List () {
            var catlist = repository.GetAll ();
            return View (catlist);
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        public IActionResult Create (Category entity) {
            if (ModelState.IsValid) {
                repository.Add (entity);
                return RedirectToAction ("List");
            }
            return View (entity);
        }

        [HttpGet]
        public IActionResult AddOrUpdate (int? id) {
            if (id == null) {
                return View (new Category ());
            } else {
                ViewBag.Categories = new SelectList (repository.GetAll (), "CategoryId", "CategoryName");
                var entity = repository.GetById ((int) id);
                return View (entity);
            }
        }

        [HttpPost]
        public IActionResult AddOrUpdate (Category entity) {
            if (ModelState.IsValid) {
                repository.Save2 (entity);
                ViewData["message"] = $"{entity.CategoryName} kaydedildi." + $"{DateTime.Now}";
                return RedirectToAction ("List");
            }
            ViewBag.Categories = new SelectList (repository.GetAll (), "CategoryId", "Name");
            return View (entity);
        }

        [HttpGet]
        public IActionResult Delete (int id) {
            repository.DeleteCategory (id);
            return RedirectToAction ("List");
        }
    }
}