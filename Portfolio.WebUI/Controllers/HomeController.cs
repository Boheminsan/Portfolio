using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI.Controllers {
    public class HomeController : Controller {

        // private IProjectRepository repository;
        private ISliderRepository repoSlider;
        private IServiceRepository repoService;
        private ITestimonialRepository repoTest;
        public HomeController (ISliderRepository _repoSlider, IServiceRepository _repoService, ITestimonialRepository _repoTest, IMenuItemRepository _repoMenu) {
            repoSlider = _repoSlider;
            repoService = _repoService;
            repoTest = _repoTest;
        }
        public IActionResult Index () {
            //bu kadar ebesinin amı değildi sanki
            var sliderModel = repoSlider.GetAll ().ToList ();
            var serviceModel = repoService.GetAll ().ToList ();
            var testModel = repoTest.GetAll ().ToList ();
            var model = new MainViewModel () {
                Sliders = sliderModel,
                Services = serviceModel,
                Testimonials = testModel,
            };
            return View (model);
        }

        public IActionResult About () {
            return View ();
        }
        public IActionResult Contact () {
            return View ();
        }
    }
}