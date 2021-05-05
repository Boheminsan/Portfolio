using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Abstract;
using Portfolio.Data.Concrete.EFCore;
using Portfolio.Entity;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI.Controllers {
    public class SliderController : Controller {
        private readonly PortfolioContext context;
        public SliderController (PortfolioContext _context) {
            context = _context;
        }
        public IActionResult Index () {
            List<Slider> model = context.Sliders.Include (p => p.Image).ToList ();
            return View (model);
        }

        [HttpGet]
        public IActionResult Create () {
            ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("ides") && p.Slider == null).ToList ();
            return View ();
        }

        [HttpPost]
        public IActionResult Create (IFormFile file, string isHomeBool, int? imgId) {
            bool isHome;
            Image img = new Image ();
            if (isHomeBool == "on") {
                isHome = true;
            } else {
                isHome = false;
            }
            if (file != null) {
                string fileFolder = "wwwroot\\assets\\img\\ides";
                string path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                using (var stream = new FileStream (path, FileMode.Create)) {
                    file.CopyTo (stream);
                    ViewBag.Message = string.Format ("<b>{0}</b> yüklendi.<br /> Yüklendiği Klasör: </br>{1}", file.FileName, path);
                }
                img = new Image () {
                    ImageName = file.FileName,
                    FullPath = "assets\\img\\ides",
                    Slider = new Slider () {
                    isHome = isHome
                    }
                };
            } else if (imgId != null) {
                img = context.Images.FirstOrDefault (i => i.ImageId == imgId);
            } else {
                ViewBag.Message = "Resim seçilmedi/yüklenmedi";
                ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("ides") && p.Slider == null).ToList ();
                return View ();
            }
            Slider entity = new Slider () {
                isHome = isHome,
                Image = img
            };
            context.Sliders.Add (entity);
            context.SaveChanges ();
            return RedirectToAction ("Index");
        }

        [HttpGet]
        public IActionResult Update (int id) {
            Slider entity = context.Sliders.Include (p => p.Image).FirstOrDefault (s => s.SliderId == id);
            ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("ides") && p.Slider == null).ToList ();
            if (entity != null) {
                return View (entity);
            }
            ViewBag.Message = "Öge bulunamadı";
            return RedirectToAction ("Index");
        }

        [HttpPost]
        public IActionResult Update (Slider model, string isHomeBool, IFormFile file, int? imgId) {
            if (ModelState.IsValid) {
                Slider entity = context.Sliders.FirstOrDefault (s => s.SliderId == model.SliderId);
                bool isHome;
                string fileFolder = "wwwroot\\assets\\img\\ides";
                Image img = new Image ();
                if (isHomeBool == "on") {
                    isHome = true;
                } else {
                    isHome = false;
                }
                if (file != null) {
                    string path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                    using (var stream = new FileStream (path, FileMode.Create)) {
                        file.CopyTo (stream);
                        ViewBag.Message = string.Format ("<b>{0}</b> yüklendi.<br /> Yüklendiği Klasör: </br>{1}", file.FileName, path);
                    }
                    img = new Image () {
                        ImageName = file.FileName,
                        FullPath = "assets\\img\\ides",
                    };
                    entity.Image = img;
                    entity.isHome = isHome;
                    context.Sliders.Update (entity);
                } else if (imgId != null) {
                    img = context.Images.Include (p => p.Slider).FirstOrDefault (i => i.ImageId == imgId);
                    img.Slider = entity;
                    img.Slider.isHome = isHome;
                    context.Images.Update (img);
                } else {
                    ViewBag.Message = "Resim seçilmedi/yüklenmedi";
                    return View (model);
                }
                context.SaveChanges ();
                return RedirectToAction ("Index");
            }
            ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("ides")).ToList ();
            return View (model);
        }

        [HttpPost]
        public IActionResult Delete (int SliderId, int ImageId) {
            Slider entity = context.Sliders.Include (i => i.Image).FirstOrDefault (s => s.SliderId == SliderId);
            if (entity != null) {
                context.Sliders.Remove (entity);
                context.SaveChanges ();
            }
            return RedirectToAction ("Index");
        }
    }
}