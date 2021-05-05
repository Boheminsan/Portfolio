using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Concrete.EFCore;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class ProjectController : Controller {

        private readonly PortfolioContext context;
        public ProjectController (PortfolioContext _context) {
            context = _context;
        }

        public IActionResult Index () {
            var model = context.Projects.ToList ();
            ViewBag.SelectedCategories = context.Categories.ToList ();
            return View (model);
        }

        [HttpGet]
        public IActionResult Create () {
            ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("portfolio")).ToList ();
            ViewBag.SelectedCategories = context.Categories.OrderBy (p => p.CType).ToList ();
            return View ();
        }

        [HttpPost]
        public IActionResult Create (Project model, int[] imageIds, int[] categoryIds, string isDone, List<IFormFile> files) {
            bool isDoneBool;
            if (isDone == "on") {
                isDoneBool = true;
            } else {
                isDoneBool = false;
            }
            string CoverImageString = "";
            if (imageIds != null) {
                CoverImageString = context.Images.FirstOrDefault (i => i.ImageId == imageIds[0]).ImageName;
            }
            List<Image> imgList = new List<Image> ();
            if (imageIds.Length != 0) {
                List<Image> images = imageIds.Select (id => context.Images.FirstOrDefault (i => i.ImageId == id)).ToList ();
                imgList.AddRange (images);
            }
            if (ModelState.IsValid && (files != null || files.Count != 0)) {
                var filePaths = new List<string> ();
                foreach (var file in files) {
                    if (file.Length > 0) {
                        var path = Path.Combine (Directory.GetCurrentDirectory (), "~\\assets\\img\\portfolio\\", file.FileName);
                        filePaths.Add (path);
                        using (var stream = new FileStream (path, FileMode.Create)) {
                            file.CopyTo (stream);
                        }
                        var img = new Image {
                            ImageName = file.FileName,
                            FullPath = "~\\assets\\img\\portfolio\\",
                            Project = model
                        };
                        imgList.Add (img);
                    }
                }
            }

            Project entity = new Project () {
                Title = model.Title,
                Text = model.Text,
                CoverImage = CoverImageString,
                isDone = isDoneBool,
                Categories = categoryIds.Select (id => context.Categories.FirstOrDefault (i => i.CategoryId == id)).ToList (),
                Images = imgList
            };
            context.Projects.Add (entity);
            context.SaveChanges ();
            return RedirectToAction ("Index");
        }

        [HttpGet]
        public IActionResult Update (int id) {
            Project entity = context.Projects.Include (p => p.Images).Include (p => p.Categories).FirstOrDefault (p => p.ProjectId == id);
            ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("portfolio")).ToList ();
            ViewBag.SelectedCategories = context.Categories.ToList ();
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (Project model, int[] imageIds, int[] categoryIds, string isDoneBool, List<IFormFile> files) {
            Project entity = context.Projects.Include (p => p.Images).Include (p => p.Categories).FirstOrDefault (p => p.ProjectId == model.ProjectId);
            if (entity == null) {
                return NotFound ();
            }
            entity.Categories = categoryIds.Select (id => context.Categories.FirstOrDefault (i => i.CategoryId == id)).ToList ();
            entity.Images = imageIds.Select (id => context.Images.FirstOrDefault (i => i.ImageId == id)).ToList ();
            if (imageIds != null) {
                entity.CoverImage = context.Images.FirstOrDefault (i => i.ImageId == imageIds[0]).ImageName;
            }
            if (isDoneBool == "on") {
                entity.isDone = true;
            } else {
                entity.isDone = false;
            }

            List<Image> imgList = new List<Image> ();
            if (imageIds.Length != 0) {
                List<Image> images = imageIds.Select (id => context.Images.FirstOrDefault (i => i.ImageId == id)).ToList ();
                imgList.AddRange (images);
            }
            if (ModelState.IsValid && (files != null || files.Count != 0)) {
                // long size = files.Sum (f => f.Length);
                var filePaths = new List<string> ();
                foreach (var file in files) {
                    if (file.Length > 0) {
                        string fileFolder = "wwwroot\\assets\\img\\portfolio";
                        string path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                        filePaths.Add (path);
                        using (var stream = new FileStream (path, FileMode.Create)) {
                            file.CopyTo (stream);
                        }
                        var img = new Image {
                            ImageName = file.FileName,
                            FullPath = fileFolder.Replace ("wwwroot\\", ""),
                            Project = model
                        };
                        imgList.Add (img);
                    }
                }
            }
            string CoverImageString = "";
            if (imageIds != null) {
                CoverImageString = context.Images.FirstOrDefault (i => i.ImageId == imageIds[0]).ImageName;
            }
            entity.Title = model.Title;
            entity.Text = model.Text;
            entity.CoverImage = CoverImageString;
            entity.Categories = categoryIds.Select (id => context.Categories.FirstOrDefault (i => i.CategoryId == id)).ToList ();
            entity.Images = imgList;
            context.Projects.Update (entity);
            context.SaveChanges ();
            return RedirectToAction ("Index");
        }

        [HttpPost]
        public IActionResult Delete (int ProjectId) {
            Project entity = context.Projects.Include (i => i.Images).FirstOrDefault (p => p.ProjectId == ProjectId);
            if (entity != null) {
                context.Projects.Remove (entity);
                context.SaveChanges ();
            }
            return RedirectToAction ("Index");
        }
    }
}