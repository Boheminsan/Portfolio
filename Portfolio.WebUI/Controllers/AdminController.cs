using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Data.Concrete;
using Portfolio.Entity;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI.Controllers {
    public class AdminController : Controller {
        private IUnitOfWork unitOfWork;

        public AdminController (IUnitOfWork _unitOfWork) {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index () {
            var sideMenuList = AdminSideBarRepository.SideItems;
            // var sideBarId = RouteData.Values["id"];

            var adminGonder = new AdminViewModel () {
                Categories = unitOfWork.Categories.GetAll ().ToList (),
                Contacts = unitOfWork.Contacts.GetAll ().ToList (),
                MenuItems = unitOfWork.MenuItems.GetAll ().ToList (),
                Projects = unitOfWork.Projects.GetAll ().ToList (),
                Services = unitOfWork.Services.GetAll ().ToList (),
                Sliders = unitOfWork.Sliders.GetAll ().ToList (),
                Testimonials = unitOfWork.Testimonials.GetAll ().ToList (),
                SideBar = sideMenuList
            };
            return View (adminGonder);
        }

        //category
        [HttpGet]
        public IActionResult CategoryCreate () {
            return View ();
        }

        [HttpPost]
        public IActionResult CategoryCreate (Category model) {
            if (ModelState.IsValid) {
                Category entity = new Category () {
                    CategoryName = model.CategoryName,
                    CType = model.CType,
                    Filter = model.Filter
                };
                unitOfWork.Categories.Add (entity);
                unitOfWork.SaveChanges ();
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpGet]
        public IActionResult CategoryUpdate (int id) {
            Category entity = unitOfWork
                .Categories
                .GetById (id);
            return View (entity);
        }

        [HttpPost]
        public IActionResult CategoryUpdate (Category model) {
            if (ModelState.IsValid) {
                Category entity = unitOfWork.Categories.GetById (model.CategoryId);
                entity.CategoryName = model.CategoryName;
                entity.CType = model.CType;
                entity.Filter = model.Filter;
                unitOfWork.SaveChanges ();
                return RedirectToAction ("Index");
            }
            return View (model);
        }

        [HttpPost]
        public IActionResult CategoryDelete (int CategoryId) {
            Category entity = unitOfWork.Categories.GetById (CategoryId);
            if (entity != null) {
                unitOfWork.Categories.Delete (entity);
                unitOfWork.SaveChanges ();
            }
            return RedirectToAction ("Index");
        }
        //project
        public IActionResult ProjectCreate () {
            return View ();
        }
        public IActionResult ProjectUpdate () {
            return View ();
        }
        public IActionResult ProjectDelete () {
            return View ();
        }
        //service
        [HttpGet]
        public IActionResult ServiceCreate () {
            return View ();
        }

        [HttpPost]
        public IActionResult ServiceCreate (Service model) {
            Service entity = new Service () {
                Image = model.Image,
                isHome = model.isHome,
                Title = model.Title,
                Text = model.Text
            };
            unitOfWork.Services.Add (entity);
            unitOfWork.SaveChanges ();
            return View ();
        }

        [HttpGet]
        public IActionResult ServiceUpdate (int ServiceId) {
            return View ();
        }

        [HttpPost]
        public IActionResult ServiceUpdate (Service model) {
            return View ();
        }
        public IActionResult ServiceDelete (int ServiceId) {
            return View ();
        }
        //slider
        [HttpGet]
        public IActionResult SliderCreate () {
            return View ();
        }

        [HttpPost]
        public IActionResult SliderCreate (Slider model) {
            Slider entity = new Slider () {
                Image = model.Image,
                isHome = model.isHome
            };
            unitOfWork.Sliders.Add (entity);
            unitOfWork.SaveChanges ();
            return View ();
        }

        [HttpGet]
        public IActionResult SliderUpdate (int SliderId) {
            Slider entity = unitOfWork.Sliders.GetById (SliderId);

            return View (entity);
        }

        [HttpPost]
        public IActionResult SliderUpdate (Slider model) {
            Slider entity = unitOfWork.Sliders.GetById (model.SliderId);
            entity.Image = model.Image;
            entity.isHome = model.isHome;
            unitOfWork.SaveChanges ();
            return View ();
        }

        [HttpPost]
        public IActionResult SliderDelete (int SliderId) {
            return View ();
        }
        //testimonial
        public IActionResult TestimonialCreate () {
            return View ();
        }
        public IActionResult TestimonialUpdate () {
            return View ();
        }
        public IActionResult TestimonialDelete () {
            return View ();
        }
        //menuitem
        [HttpGet]
        public IActionResult MenuItemCreate () {
            return View ();
        }

        [HttpPost]
        public IActionResult MenuItemCreate (MenuItem model) {
            MenuItem entity = new MenuItem () {
                MenuItemName = model.MenuItemName,
                Link = model.Link,
                ParentId = model.ParentId
            };
            unitOfWork.MenuItems.Add (entity);
            unitOfWork.SaveChanges ();
            return RedirectToAction ("Index");
        }

        [HttpGet]
        public IActionResult MenuItemUpdate (int MenuId) {
            MenuItem entity = unitOfWork.MenuItems.GetById (MenuId);
            return View (entity);
        }

        [HttpPost]
        public IActionResult MenuItemUpdate (MenuItem model) {
            if (ModelState.IsValid) {
                MenuItem entity = unitOfWork.MenuItems.GetById (model.MenuItemId);
                entity.MenuItemName = model.MenuItemName;
                entity.ParentId = model.ParentId;
                unitOfWork.SaveChanges ();
            }
            return View ();
        }

        [HttpPost]
        public IActionResult MenuItemDelete (int MenuId) {
            MenuItem entity = unitOfWork.MenuItems.GetById (MenuId);
            if (entity != null) {
                unitOfWork.MenuItems.Delete (entity);
                unitOfWork.SaveChanges ();
            }
            return RedirectToAction ("Index");
        }

        //contact
        [HttpPost]
        public IActionResult ContactDelete (int ContactId) {
            Contact entity = unitOfWork.Contacts.GetById (ContactId);
            if (entity != null) {
                unitOfWork.Contacts.Delete (entity);
                unitOfWork.SaveChanges ();
            }
            return RedirectToAction ("Index");
        }

        // public IActionResult ListProjects () {
        //     return View ();
        // }

    }
}