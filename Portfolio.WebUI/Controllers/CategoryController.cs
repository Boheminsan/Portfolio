using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
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
        public IActionResult Create (Category model, string cType) {
            Category entity = new Category ();
            if (ModelState.IsValid) {
                entity.CategoryName = model.CategoryName;
                if (cType != null) {
                    if (cType == "Lang") {
                        entity.CType = CategoryType.Lang;
                    } else {
                        entity.CType = CategoryType.Tech;
                    }
                } else {
                    ModelState.AddModelError ("", "Kategori türü boş bırakılamaz.");
                    return View (model);
                }
                if (!model.Filter.StartsWith (".")) {
                    if (model.Filter.Contains (".")) {
                        model.Filter.Replace (".", "");
                    }
                    entity.Filter = "." + model.Filter;
                } else {
                    entity.Filter = model.Filter;
                }
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
            if (!entity.Filter.StartsWith (".")) {
                entity.Filter = "." + entity.Filter;
            }
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
                    if (!model.Filter.StartsWith (".")) {
                        if (model.Filter.Contains (".")) {
                            model.Filter.Replace (".", "");
                        }
                        entity.Filter = "." + model.Filter;
                    } else {
                        entity.Filter = model.Filter;
                    }
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

        [HttpPost]
        public IActionResult DeleteProject (int CategoryId, int ProjectId) {
            Project project = context.Projects.Include (p => p.Categories).FirstOrDefault (c => c.ProjectId == ProjectId);
            Category entity = context.Categories.FirstOrDefault (c => c.CategoryId == CategoryId);
            if (project != null) {
                project.Categories.Remove (entity);
                context.SaveChanges ();
                ViewData["message"] = $"{project.Title}, ${entity.CategoryName}'den silindi." + $"{DateTime.Now}";
            }
            return View ("Update", entity);
        }
    }
}