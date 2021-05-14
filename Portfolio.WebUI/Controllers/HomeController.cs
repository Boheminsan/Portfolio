using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI.Controllers {
    public class HomeController : Controller {

        private IUnitOfWork unitOfWork;
        public HomeController (IUnitOfWork _unitOfWork) {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index () {
            ViewBag.Selected = "Anasayfa";
            var model = new MainViewModel () {
                Images = unitOfWork.Images.GetAll ().ToList (),
                Sliders = unitOfWork.Sliders.GetAll ().Where (s => s.isHome == true).OrderBy (p => p.SliderId).Take (10).ToList (),
                Services = unitOfWork.Services.GetAll ().Where (s => s.isHome == true).OrderBy (p => p.ServiceId).Take (4).ToList (),
                Testimonials = unitOfWork.Testimonials.GetAll ().Where (s => s.isHome == true).ToList ()
            };
            return View (model);
        }

        public IActionResult About () {
            ViewBag.Selected = "Hakkımda";
            return View ();
        }

        [HttpGet]
        public IActionResult Contact () {
            ViewBag.Selected = "İletişim";
            TempData["Code"] = null;
            return View ();
        }

        [HttpPost]
        public IActionResult Contact (Contact model) {
            ViewBag.Selected = "İletişim";
            if (ModelState.IsValid) {
                unitOfWork.Contacts.Add (model);
                TempData["Code"] = "1";
                unitOfWork.SaveChanges ();
                return RedirectToAction ("Contact");
            }
            TempData["Code"] = "0";
            return View ();
        }

        [HttpGet]
        public async Task<IActionResult> DownloadCV (string filename) {
            if (filename == null)
                return Content ("Dosya Bulunamadı");
            var path = Path.Combine (
                Directory.GetCurrentDirectory (),
                "wwwroot\\assets\\cv\\", filename);
            var memory = new MemoryStream ();
            using (var stream = new FileStream (path, FileMode.Open)) {
                await stream.CopyToAsync (memory);
            }
            memory.Position = 0;
            return File (memory, "application/pdf", Path.GetFileName (path));
        }
    }
}