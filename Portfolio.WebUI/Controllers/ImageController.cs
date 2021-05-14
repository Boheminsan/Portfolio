using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Data.Concrete.EFCore;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class ImageController : Controller {
        private readonly PortfolioContext context;
        public ImageController (PortfolioContext _context) {
            context = _context;
        }

        public IActionResult Index () {
            var images = context.Images.ToList ();
            return View (images);
        }

        [HttpGet]

        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        public IActionResult Create (IFormFile file, string folder) {
            if (file != null) {
                string fileFolder = "";
                string path = "";
                if (folder == "portfolio") {
                    fileFolder = "wwwroot\\assets\\img\\portfolio";
                    path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                } else if (folder == "services") {
                    fileFolder = "wwwroot\\assets\\img\\services";
                    path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                } else if (folder == "clients") {
                    fileFolder = "wwwroot\\assets\\img\\clients";
                    path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                } else if (folder == "ides") {
                    fileFolder = "wwwroot\\assets\\img\\ides";
                    path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                } else {
                    fileFolder = "wwwroot\\assets\\img";
                    path = Path.Combine (Directory.GetCurrentDirectory (),
                        fileFolder, file.FileName);
                }
                if (!Directory.Exists (fileFolder)) {
                    Directory.CreateDirectory (fileFolder);
                }
                string filename = string.Format (file.FileName);
                using (var stream = new FileStream (path, FileMode.Create)) {
                    file.CopyTo (stream);
                    ViewBag.Message = string.Format ("<b>{0}</b> yüklendi.<br /> Yüklendiği Klasör: </br>{1}", file.FileName, path);
                }
                Image entity = new Image () {
                    ImageName = file.FileName,
                    FullPath = fileFolder.Replace ("wwwroot\\", "")
                };
                context.Images.Add (entity);
                context.SaveChanges ();
                return RedirectToAction ("Index");
            }
            ViewBag.Message = "Dosya Seçilmedi";
            return View ();
        }

        [HttpGet]
        public IActionResult Update (int id) {
            Image entity = context.Images.FirstOrDefault (p => p.ImageId == id);
            ViewBag.Folder = Directory.GetParent (entity.FullPath + "\\" + entity.ImageName);
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (Image model, IFormFile file, string folder) {
            if (file != null) {
                string fileFolder = "";
                string path = "";
                if (folder != "else") {
                    fileFolder = "wwwroot\\assets\\img\\" + folder;
                } else {
                    fileFolder = "wwwroot\\assets\\img";
                }
                path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                Image entity = context.Images.FirstOrDefault (i => i.ImageId == model.ImageId);
                using (var stream = new FileStream (path, FileMode.Create)) {
                    file.CopyTo (stream);
                }
                if (entity != null) {
                    entity.ImageName = file.FileName;
                    entity.FullPath = fileFolder.Replace ("wwwroot\\", "");
                }
                context.Images.Update (entity);
                context.SaveChanges ();
                ViewBag.Message = string.Format ("<b>{0}</b> yüklendi.<br /> Yüklendiği Klasör: </br>{1}", file.FileName, path);
                return RedirectToAction ("Index");
            } else {
                string fileFolder = "";
                if (folder != "else") {
                    fileFolder = "wwwroot\\assets\\img\\" + folder;
                } else {
                    fileFolder = "wwwroot\\assets\\img";
                }
                Image entity = context.Images.FirstOrDefault (i => i.ImageId == model.ImageId);

                var sourcePath = Path.Combine (Directory.GetCurrentDirectory (), "wwwroot\\" + entity.FullPath, entity.ImageName);
                var destPath = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, entity.ImageName);
                System.IO.File.Move (sourcePath, destPath);
                if (entity != null) {
                    entity.FullPath = fileFolder.Replace ("wwwroot\\", "");
                }
                context.Images.Update (entity);
                context.SaveChanges ();
                ViewBag.Message = string.Format ("<b>{0}</b> yüklendi.<br /> Yüklendiği Klasör: </br>{1}", entity.ImageName, destPath);
                ViewBag.Folder = folder;
                return RedirectToAction ("Index");
            }
        }
    }
}