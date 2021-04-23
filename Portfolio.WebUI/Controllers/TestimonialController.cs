using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class TestimonialController : Controller {
        private ITestimonialRepository repository;
        public TestimonialController (ITestimonialRepository _repo) {
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
        public IActionResult Create (Testimonial model) {
            if (ModelState.IsValid) {
                Testimonial entity = new Testimonial () {
                    Title = model.Title,
                    Text = model.Text,
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
            Testimonial entity = repository.GetById (id);
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (Testimonial model) {
            if (ModelState.IsValid) {
                Testimonial entity = repository.GetById (model.TestimonialId);
                entity.Title = model.Title;
                entity.Text = model.Text;
                entity.Image = model.Image;
                entity.isHome = model.isHome; //radiobutton
                repository.Save ();
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpPost]
        public IActionResult Delete (int TestimonialId) {
            Testimonial entity = repository.GetById (TestimonialId);
            if (entity != null) {
                repository.Delete (entity);
                repository.Save ();
            }
            return RedirectToAction ("Index");
        }
    }
}