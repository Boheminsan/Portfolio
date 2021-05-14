using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Abstract;
using Portfolio.Data.Concrete.EFCore;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class TestimonialController : Controller {
        private readonly PortfolioContext context;
        public TestimonialController (PortfolioContext _context) {
            context = _context;
        }
        public IActionResult Index () {
            var model = context.Testimonials.Include (p => p.Image).ToList ();
            return View (model);
        }

        [HttpGet]
        public IActionResult Create () {
            ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("clients") && p.Testimonial == null).ToList ();
            return View ();
        }

        [HttpPost]
        public IActionResult Create (Testimonial model, IFormFile file, string isHomeBool, int? imgId) {
            bool isHome;
            Image img = new Image ();
            if (isHomeBool == "on") {
                isHome = true;
            } else {
                isHome = false;
            }
            if (file != null) {
                string fileFolder = "wwwroot\\assets\\img\\clients";
                string path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                using (var stream = new FileStream (path, FileMode.Create)) {
                    file.CopyTo (stream);
                    ViewBag.Message = string.Format ("<b>{0}</b> yüklendi.<br /> Yüklendiği Klasör: </br>{1}", file.FileName, path);
                }
                img = new Image () {
                    ImageName = file.FileName,
                    FullPath = "assets\\img\\clients",
                    Testimonial = new Testimonial () {
                    isHome = isHome
                    }
                };
            } else if (imgId != null) {
                img = context.Images.FirstOrDefault (i => i.ImageId == imgId);
            } else {
                ViewBag.Message = "Resim seçilmedi/yüklenmedi";
                ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("clients") && p.Testimonial == null).ToList ();
                return View ();
            }
            Testimonial entity = new Testimonial () {
                Title = model.Title,
                Text = model.Text,
                Image = img,
                isHome = isHome
            };
            context.Testimonials.Add (entity);
            context.SaveChanges ();
            return RedirectToAction ("Index");
        }

        [HttpGet]
        public IActionResult Update (int id) {
            Testimonial entity = context.Testimonials.Include (t => t.Image).FirstOrDefault (i => i.TestimonialId == id);
            ViewBag.Images = context.Images.Where (p => p.FullPath.Contains ("clients") && p.Testimonial == null).ToList ();
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (Testimonial model, IFormFile file, string isHomeBool, int? imgId) {
            bool isHome;
            if (isHomeBool == "on") {
                isHome = true;
            } else {
                isHome = false;
            }
            if (ModelState.IsValid) {
                Image img = new Image ();
                Testimonial entity = context.Testimonials.FirstOrDefault (i => i.TestimonialId == model.TestimonialId);
                entity.Title = model.Title;
                if (file != null) {
                    string fileFolder = "wwwroot\\assets\\img\\clients";
                    string path = Path.Combine (Directory.GetCurrentDirectory (), fileFolder, file.FileName);
                    using (var stream = new FileStream (path, FileMode.Create)) {
                        file.CopyTo (stream);
                        ViewBag.Message = string.Format ("<b>{0}</b> yüklendi.<br /> Yüklendiği Klasör: </br>{1}", file.FileName, path);
                    }
                    img = new Image () {
                        ImageName = file.FileName,
                        FullPath = "assets\\img\\Testimonials"
                    };
                    entity.Image = img;
                } else if (imgId != null) {
                    img = context.Images.FirstOrDefault (i => i.ImageId == imgId);
                    entity.Image = img;
                } else {
                    entity.Text = model.Text;
                    entity.isHome = isHome;
                    context.Testimonials.Update (entity);
                    context.SaveChanges ();
                    return RedirectToAction ("Index");
                }
            }
            return View (model);
        }

        [HttpPost]
        public IActionResult Delete (int TestimonialId) {
            Testimonial entity = context.Testimonials.FirstOrDefault (i => i.TestimonialId == TestimonialId);
            if (entity != null) {
                context.Testimonials.Remove (entity);
                context.SaveChanges ();
            }
            return RedirectToAction ("Index");
        }
    }
}