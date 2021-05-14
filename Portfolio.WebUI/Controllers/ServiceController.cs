using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Abstract;
using Portfolio.Data.Concrete.EFCore;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class ServiceController : Controller {
        private readonly PortfolioContext context;
        public ServiceController (PortfolioContext _context) {
            context = _context;
        }
        public IActionResult Index () {
            var model = context.Services.Include (p => p.Image).ToList ();
            return View (model);
        }

        [HttpGet]
        public IActionResult Create () {
            ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("services") && p.Service == null).ToList ();
            return View ();
        }

        [HttpPost]
        public IActionResult Create (Service model, IFormFile file, string isHomeBool, int? imgId) {
            bool isHome;
            Image img = new Image ();
            if (isHomeBool == "on") {
                isHome = true;
            } else {
                isHome = false;
            }
            if (file != null) {
                string fileFolder = "wwwroot\\assets\\img\\services";
                string path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                using (var stream = new FileStream (path, FileMode.Create)) {
                    file.CopyTo (stream);
                    ViewBag.Message = string.Format ("<b>{0}</b> yüklendi.<br /> Yüklendiği Klasör: </br>{1}", file.FileName, path);
                }
                img = new Image () {
                    ImageName = file.FileName,
                    FullPath = "assets\\img\\services",
                    Service = new Service () {
                    isHome = isHome
                    }
                };
            } else if (imgId != null) {
                img = context.Images.FirstOrDefault (i => i.ImageId == imgId);
            } else {
                ViewBag.Message = "Resim seçilmedi/yüklenmedi";
                ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("services") && p.Service == null).ToList ();
                return View ();
            }
            Service entity = new Service () {
                Title = model.Title,
                Text = model.Text,
                Image = img,
                isHome = isHome
            };
            context.Services.Add (entity);
            context.SaveChanges ();
            return RedirectToAction ("Index");
        }

        [HttpGet]
        public IActionResult Update (int id) {
            Service entity = context.Services.Include (p => p.Image).FirstOrDefault (i => i.ServiceId == id);
            ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("services") && p.Service == null).ToList ();
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (Service model, IFormFile file, string isHomeBool, int? imgId) {
            bool isHome;
            if (isHomeBool == "on") {
                isHome = true;
            } else {
                isHome = false;
            }
            if (ModelState.IsValid) {
                Image img = new Image ();
                Service entity = context.Services.FirstOrDefault (i => i.ServiceId == model.ServiceId);
                if (file != null) {
                    string fileFolder = "wwwroot\\assets\\img\\services";
                    string path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                    using (var stream = new FileStream (path, FileMode.Create)) {
                        file.CopyTo (stream);
                        ViewBag.Message = string.Format ("<b>{0}</b> yüklendi.<br /> Yüklendiği Klasör: </br>{1}", file.FileName, path);
                    }
                    img = new Image () {
                        ImageName = file.FileName,
                        FullPath = "assets\\img\\services"
                    };
                    entity.Image = img;
                } else if (imgId != null) {
                    img = context.Images.FirstOrDefault (i => i.ImageId == imgId);
                    entity.Image = img;
                } else {
                    entity.Title = model.Title;
                    entity.Text = model.Text;
                    entity.isHome = isHome;
                    context.Services.Update (entity);
                    context.SaveChanges ();
                    return RedirectToAction ("Index");
                }
            }
            return View (model);
        }

        [HttpPost]
        public IActionResult Delete (int ServiceId) {
            Service entity = context.Services.FirstOrDefault (i => i.ImageId == ServiceId);
            if (entity != null) {
                context.Services.Remove (entity);
                context.SaveChanges ();
            }
            return RedirectToAction ("Index");
        }
    }
}