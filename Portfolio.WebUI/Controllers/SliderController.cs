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
                Slider entity = new Slider () {
                    Image = model.Img,
                    isHome = model.Slider.isHome,
                    Caption = model.Slider.Caption
                };
                repository.Add (entity);
                repository.Save ();
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
        public IActionResult Update (Slider model) {
            if (ModelState.IsValid) {
                Slider entity = repository.GetById (model.SliderId);
                entity.Image = model.Image;
                entity.isHome = model.isHome; //radiobutton
                repository.Save ();
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpPost]
        public IActionResult Delete (int SliderId) {
            Slider entity = repository.GetById (SliderId);
            if (entity != null) {
                repository.Delete (entity);
                repository.Save ();
            }
            return RedirectToAction ("Index");
        }
    }
}