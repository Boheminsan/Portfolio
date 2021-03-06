using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI.Controllers {
    public class AdminController : Controller {
        private IProjectRepository repoPro;
        private ICategoryRepository repoCat;
        private IMenuItemRepository repoMenu;
        private IContactRepository repoCon;
        private IServiceRepository repoSer;
        private IImageRepository repoImg;
        private ITestimonialRepository repoTest;
        private ISliderRepository repoSlider;

        public AdminController (IProjectRepository _repoPro, ICategoryRepository _repoCat, IMenuItemRepository _repoMenu, IContactRepository _repoCon, IServiceRepository _repoSer, IImageRepository _repoImg, ITestimonialRepository _repoTest, ISliderRepository _repoSlider) {
            repoSlider = _repoSlider;
            repoTest = _repoTest;
            repoImg = _repoImg;
            repoSer = _repoSer;
            repoCon = _repoCon;
            repoMenu = _repoMenu;
            repoCat = _repoCat;
            repoPro = _repoPro;
        }
        public IActionResult Index () {
            var sideMenuList = new List<MenuItem> () {
                new MenuItem () { MenuItemName = "Category", Link = "#" },
                new MenuItem () { MenuItemName = "Contact", Link = "#" },
                new MenuItem () { MenuItemName = "Images", Link = "#" },
                new MenuItem () { MenuItemName = "Slider", Link = "#" },
                new MenuItem () { MenuItemName = "Project", Link = "#" },
                new MenuItem () { MenuItemName = "Menu", Link = "#" },
                new MenuItem () { MenuItemName = "Service", Link = "#" },
                new MenuItem () { MenuItemName = "Testimonials", Link = "#" },
            };
            var adminGonder = new AdminViewModel () {
                Categories = repoCat.GetAll ().ToList (),
                //Contacts = repoCon.GetAll ().ToList (),
                Images = repoImg.GetAll ().ToList (),
                MenuItems = repoMenu.GetAll ().ToList (),
                Projects = repoPro.GetAll ().ToList (),
                Services = repoSer.GetAll ().ToList (),
                Sliders = repoSlider.GetAll ().ToList (),
                SideBar = sideMenuList,
                Testimonials = repoTest.GetAll ().ToList ()
            };
            return View (adminGonder);
        }

        // public IActionResult ListMain () {
        //     return View ();
        // }

        // public IActionResult ListCategories () {
        //     return View ();
        // }

        // public IActionResult ListProjects () {
        //     return View ();
        // }

    }
}