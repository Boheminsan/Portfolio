using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class ImageController : Controller {
        IImageRepository repository;
        public ImageController (IImageRepository _repository) {
            repository = _repository;
        }
        public IActionResult Index () {
            var images = repository.GetAll ().ToList ();
            return View (images);
        }

        [HttpGet]

        public IActionResult Create () {

            return View ();
        }

        [HttpPost]

        public IActionResult Create (Image model) {
            Image entity = new Image () {
                ImageName = model.ImageName,
                Path = model.Path
            };
            repository.Add (entity);
            repository.Save ();
            return RedirectToAction ("Index");
        }

        [HttpGet]
        public IActionResult Update (int id) {
            Image entity = repository.GetById (id);
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (Image model) {
            Image entity = repository.GetById (model.ImageId);
            entity.ImageName = model.ImageName;
            entity.Path = model.Path;
            repository.Save ();
            return RedirectToAction ("Index");
        }
    }
}