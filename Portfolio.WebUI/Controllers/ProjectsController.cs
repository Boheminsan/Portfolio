using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Abstract;
using Portfolio.Data.Concrete.EFCore;
using Portfolio.Entity;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI.Controllers {
    public class ProjectsController : Controller {
        private readonly PortfolioContext context;
        private IUnitOfWork unitOfWork;
        public ProjectsController (IUnitOfWork _unitOfWork, PortfolioContext _context) {
            context = _context;
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index () {
            return View ("Done");
        }
        public IActionResult Done (int? id) {
            ViewBag.Selected = RouteData.Values["action"];
            ViewBag.SelectedCategories = context.Categories.ToList ();
            if (id != null) {
                var model = context.Projects.Include (p => p.Categories).Include (p => p.Images).Where (p => p.isDone == true && p.ProjectId == (int) id);
                return View ("Details", model);
            } else {
                var model = context.Projects.Include (p => p.Categories).Include (p => p.Images).Where (p => p.isDone == true).ToList ();
                return View (model);
            }
        }

        public IActionResult Draft (int? id) {
            ViewBag.Selected = RouteData.Values["action"];
            ViewBag.SelectedCategories = context.Categories.ToList ();
            if (id != null) {
                var model = context.Projects.Include (p => p.Categories).Include (p => p.Images).Where (p => p.isDone == false && p.ProjectId == (int) id);
                return View ("Details", model);
            } else {
                var model = context.Projects.Include (p => p.Categories).Include (p => p.Images).Where (p => p.isDone == false).ToList ();
                return View (model);

            }
        }
    }
}