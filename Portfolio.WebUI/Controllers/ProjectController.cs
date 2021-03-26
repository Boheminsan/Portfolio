using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI.Controllers {
    public class ProjectController : Controller {

        private IProjectRepository repository;
        private IMenuItemRepository repoMenu;
        private ICategoryRepository repoCat;

        public ProjectController (IProjectRepository _repository, IMenuItemRepository _repoMenu, ICategoryRepository _repoCat) {
            repository = _repository;
            repoMenu = _repoMenu;
            repoCat = _repoCat;
        }

        public IActionResult Done () {
            //category filter null çöz

            var projectModel = repository.GetAll ().Where (p => p.isDone == true).ToList ();
            var categoryModel = repoCat.GetAll ().ToList ();
            var proCat = new ProjectCategoryViewModel () {
                Categories = categoryModel,
                Projects = projectModel
            };
            return View (proCat);
        }

        public IActionResult Draft () {
            var projectModel = repository.GetAll ().Where (p => p.isDone == false).ToList ();
            return View (projectModel);
        }
    }
}