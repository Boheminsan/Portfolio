using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.WebUI.Controllers {
    public class ProjectController : Controller {
        private IProjectRepository repository;
        private IImageRepository repoImg;
        public ProjectController (IProjectRepository _repo, IImageRepository _repoImg) {
            repository = _repo;
            repoImg = _repoImg;
        }
        public IActionResult Index () {
            var model = repository.GetAll ().ToList ();
            return View (model);
        }

        [HttpGet]
        public IActionResult Create () {
            List<Image> ListImages = repoImg.GetFolder ("/img/portfolio");
            Project deneme = new Project () {
                Images = ListImages
            };
            return View (deneme);
        }

        [HttpPost]
        public IActionResult Create (Project model) {
            if (ModelState.IsValid) {
                Project entity = new Project () {
                    Title = model.Title,
                    Text = model.Text,
                    CoverImage = model.CoverImage,
                    isDone = model.isDone,
                    isHome = model.isHome
                };
                repository.Add (entity);
                repository.Save ();
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpGet]

        public IActionResult Update (int id) {
            Project entity = repository.GetById (id);
            return View (entity);
        }

        [HttpPost]
        public IActionResult Update (Project model) {
            if (ModelState.IsValid) {
                Project entity = repository.GetById (model.ProjectId);
                entity.Title = model.Title;
                entity.CoverImage = model.CoverImage;
                entity.Text = model.Text;
                entity.isHome = model.isHome; //radiobutton
                entity.isDone = model.isDone;
                repository.Save ();
                return RedirectToAction ("Index");
            }
            return View (model);
        }

        [HttpPost]
        public IActionResult Delete (int ProjectId) {
            Project entity = repository.GetById (ProjectId);
            if (entity != null) {
                repository.Delete (entity);
                repository.Save ();
            }
            return RedirectToAction ("Index");
        }
    }
}