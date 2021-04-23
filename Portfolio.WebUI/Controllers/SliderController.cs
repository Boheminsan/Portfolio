using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class SliderController : Controller {
        private ISliderRepository repository;
        public SliderController (ISliderRepository _repo) {
            repository = _repo;
        }
        public IActionResult Index () {
            var model = repository.GetAll ().ToList ();
            return View (model);
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        public IActionResult Create (Slider model) {
            if (ModelState.IsValid) {
                Slider entity = new Slider () {
                    Image = model.Image,
                    isHome = model.isHome //radiobutton
                };
                repository.Add (entity);
                repository.Save ();
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpGet]
        public IActionResult Update (int id) {
            Slider entity = repository.GetById (id);
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