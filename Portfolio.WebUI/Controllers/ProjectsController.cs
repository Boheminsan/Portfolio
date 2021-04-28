using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI.Controllers {
    public class ProjectsController : Controller {
        private IUnitOfWork unitOfWork;
        public ProjectsController (IUnitOfWork _unitOfWork) {
            unitOfWork = _unitOfWork;
        }

        public IActionResult Index () {
            return View ("Done");
        }
        public IActionResult Done (int? id) {
            ViewBag.Selected = RouteData.Values["action"];
            var cat = unitOfWork.Categories.GetAll ().ToList ();
            //projenin kategorilerini getir
            if (id != null) {
                var pro = unitOfWork.Projects.GetById ((int) id);
                var img = unitOfWork.Images.GetAll ().Where (p => p.Project.ProjectId == id && p.Project.isDone == true).ToList ();
                var model = new ProjectImageViewModel () {
                    Categories = cat,
                    Project = pro,
                    Images = img
                };
                return View ("Details", model);
            } else {
                var pro = unitOfWork.Projects.GetAll ().Where (p => p.isDone == true).ToList ();
                var model = new ProjectCategoryViewModel () {
                    Categories = cat,
                    Projects = pro
                };
                return View (model);
            }
        }

        public IActionResult Draft (int? id) {
            ViewBag.Selected = RouteData.Values["action"];
            var cat = unitOfWork.Categories.GetAll ().ToList ();
            //projenin kategorilerini getir
            if (id != null) {
                var pro = unitOfWork.Projects.GetById ((int) id);
                var img = unitOfWork.Images.GetAll ().Where (p => p.Project.ProjectId == id && p.Project.isDone == false).ToList ();
                var model = new ProjectImageViewModel () {
                    Categories = cat,
                    Project = pro,
                    Images = img
                };
                return View ("Details", model);
            } else {
                var pro = unitOfWork.Projects.GetAll ().Where (p => p.isDone == false).ToList ();
                var model = new ProjectCategoryViewModel () {
                    Categories = cat,
                    Projects = pro
                };
                return View (model);
            }
        }
    }
}