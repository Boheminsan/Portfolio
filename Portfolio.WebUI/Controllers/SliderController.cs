using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI.Controllers {
    public class SliderController : Controller {
        private ISliderRepository repository;
        private IImageRepository repoImg;
        public SliderController (ISliderRepository _repo, IImageRepository _repoImg) {
            repository = _repo;
            repoImg = _repoImg;
        }
        public IActionResult Index () {
            SliderImageViewModel model = new SliderImageViewModel () {
                Sliders = repository.GetAll ().ToList (),
                Images = repoImg.GetAll ().Where (s => s.Path == "img/ides").ToList ()
            };
            return View (model);
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        public IActionResult Create (SliderImageSingleViewModel model) {
            if (ModelState.IsValid) {
                Image imgent = new Image () {
                    ImageName = model.Img.ImageName,
                    Path = "img/ides",
                    Slider = model.Slider
                };
                repoImg.Add (imgent);
                repoImg.Save ();
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpGet]
        public IActionResult Update (int id) {
            Slider slider = repository.GetById (id);
            Image img = repoImg.Find (s => s.ImageId == slider.ImageId).FirstOrDefault ();
            SliderImageSingleViewModel entity = new SliderImageSingleViewModel () {
                Slider = slider,
                Img = img
            };
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (SliderImageSingleViewModel model, string isHomeBool) {
            if (ModelState.IsValid) {
                Image entity = repoImg.Find (s => s.ImageId == model.Img.ImageId).FirstOrDefault ();
                entity.ImageName = model.Img.ImageName;
                entity.Path = "img/ides";
                Slider entSlid = repository.GetById (model.Slider.SliderId);
                if (isHomeBool == "on") {
                    entSlid.isHome = true;
                } else {
                    entSlid.isHome = false;
                }
                repository.Save ();
                repoImg.Save ();
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpPost]
        public IActionResult Delete (int SliderId, int ImageId) {
            Slider entity = repository.GetById (SliderId);
            Image entimg = repoImg.Find (s => s.ImageId == ImageId).FirstOrDefault ();
            if (entity != null && entimg != null) {
                repoImg.Delete (entimg);
                repoImg.Save ();
            }
            return RedirectToAction ("Index");
        }
    }
}