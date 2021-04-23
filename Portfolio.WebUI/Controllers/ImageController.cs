using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;

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
    }
}