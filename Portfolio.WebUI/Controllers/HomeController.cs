using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
                Sliders = unitOfWork.Sliders.GetAll ().Where (s => s.isHome == true).ToList (),
                Services = unitOfWork.Services.GetAll ().Where (s => s.isHome == true).ToList (),
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
                return View ();
            }
            TempData["Code"] = "0";
            return View ();
        }
    }
}