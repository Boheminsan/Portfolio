using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class ServiceController : Controller {
        private IServiceRepository repository;
        public ServiceController (IServiceRepository _repo) {
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
        public IActionResult Create (Service model) {
            if (ModelState.IsValid) {
                Service entity = new Service () {
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
            Service entity = repository.GetById (id);
            //if null
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (Service model) {
            if (ModelState.IsValid) {
                Service entity = repository.GetById (model.ServiceId);
                entity.Title = model.Title;
                entity.Image = model.Image;
                entity.Text = model.Text;
                entity.isHome = model.isHome; //radiobutton
                repository.Save ();
                return RedirectToAction ("Index");
            }
            return View (model);
        }

        [HttpPost]
        public IActionResult Delete (int ServiceId) {
            Service entity = repository.GetById (ServiceId);
            if (entity != null) {
                repository.Delete (entity);
                repository.Save ();
            }
            return RedirectToAction ("Index");
        }
    }
}