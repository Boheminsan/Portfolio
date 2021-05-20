using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Concrete.EFCore;
using System.Linq;

namespace Portfolio.WebUI.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly PortfolioContext context;
        public ProjectsController(PortfolioContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View("Done");
        }
        public IActionResult Done(int? id)
        {
            ViewBag.Selected = RouteData.Values["action"];
            ViewBag.SelectedCategories = context.Categories.ToList();
            if (id != null)
            {
                var model = context.Projects.Include(p => p.Images).Where(p => p.isDone == true && p.ProjectId == (int)id).FirstOrDefault();
                return View("Details", model);
            }
            else
            {
                var model = context.Projects.Include(p => p.Categories).AsSplitQuery().Include(p => p.Images).Where(p => p.isDone == true).ToList();
                ViewBag.Categories = context.Categories.ToList();
                return View(model);
            }
        }

        public IActionResult Draft(int? id)
        {
            ViewBag.Selected = RouteData.Values["action"];
            ViewBag.SelectedCategories = context.Categories.ToList();
            if (id != null)
            {
                var model = context.Projects.Include(p => p.Images).Where(p => p.isDone == false && p.ProjectId == (int)id).FirstOrDefault();
                return View("Details", model);
            }
            else
            {
                var model = context.Projects.Include(p => p.Categories).AsSplitQuery().Include(p => p.Images).Where(p => p.isDone == false).ToList();
                return View(model);

            }
        }
    }
}