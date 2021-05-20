using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;
using System.Linq;

namespace Portfolio.WebUI.Controllers
{
    public class FooterController : Controller
    {
        private IFooterRepository repository;
        public FooterController(IFooterRepository _repo)
        {
            repository = _repo;
        }
        public IActionResult Index()
        {
            var model = repository.GetAll().ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Footer model)
        {
            if (ModelState.IsValid)
            {
                Footer entity = new Footer()
                {
                    SocialMediaName = model.SocialMediaName,
                    Link = model.Link,
                    Icon = model.Icon //combobox?
                };
                repository.Add(entity);
                repository.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Footer entity = repository.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update(Footer model)
        {
            if (ModelState.IsValid)
            {
                Footer entity = repository.GetById(model.FooterId);
                entity.SocialMediaName = model.SocialMediaName;
                entity.Link = model.Link;
                entity.Icon = model.Icon;
                repository.Save();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int FooterId)
        {
            Footer entity = repository.GetById(FooterId);
            if (entity != null)
            {
                repository.Delete(entity);
                repository.Save();
            }
            return RedirectToAction("Index");
        }
    }
}