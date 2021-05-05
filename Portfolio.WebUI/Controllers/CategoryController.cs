using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Abstract;
using Portfolio.Data.Concrete.EFCore;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class CategoryController : Controller {
        private readonly PortfolioContext context;
        public CategoryController (PortfolioContext _context) {
            context = _context;
        }

        public IActionResult Index () {
            var model = context.Categories.ToList ();
            return View (model);
        }

        [HttpGet]
        public IActionResult Create () {
            ViewBag.Projects = context.Projects.ToList ();
            return View ();
        }

        [HttpPost]
        public IActionResult Create (Category model) {
            Category entity = new Category ();
            if (ModelState.IsValid) {
                entity.CategoryName = model.CategoryName;
                entity.CType = model.CType;
                entity.Filter = model.Filter;
                context.Categories.Add (entity);
                context.SaveChanges ();
                ViewData["message"] = $"{entity.CategoryName} eklendi." + $"{DateTime.Now}";
                return RedirectToAction ("Index");
            }
            return View (model);
        }

        [HttpGet]
        public IActionResult Update (int id) {
            Category entity = context.Categories.Include (p => p.Projects).FirstOrDefault (c => c.CategoryId == id);
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (Category model, int[] projectIds) {
            if (ModelState.IsValid) {
                if (projectIds != null) {
                    List<Project> SelProjects = projectIds.Select (p => context.Projects.FirstOrDefault (cp => cp.ProjectId == p)).ToList ();
                    Category entity = context.Categories.Include (p => p.Projects).FirstOrDefault (c => c.CategoryId == model.CategoryId);
                    entity.CategoryName = model.CategoryName;
                    entity.CType = model.CType;
                    entity.Filter = model.Filter;
                    entity.Projects = SelProjects;
                    context.Categories.Update (entity);
                    context.SaveChanges ();
                    ViewData["message"] = $"{entity.CategoryName} güncellendi." + $"{DateTime.Now}";
                    return RedirectToAction ("Index");
                }
            }
            return View (model);
        }

        [HttpPost]
        public IActionResult Delete (int CategoryId) {
            Category entity = context.Categories.FirstOrDefault (c => c.CategoryId == CategoryId);
            if (entity != null) {
                context.Categories.Remove (entity);
                context.SaveChanges ();
                ViewData["message"] = $"{entity.CategoryName} silindi." + $"{DateTime.Now}";
            }
            return RedirectToAction ("Index");
        }
    }
}