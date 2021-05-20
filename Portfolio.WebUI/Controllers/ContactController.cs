using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using Portfolio.Entity;
using System.Linq;

namespace Portfolio.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private IContactRepository repository;
        public ContactController(IContactRepository _repo)
        {
            repository = _repo;
        }
        public IActionResult Index()
        {
            var model = repository.GetAll().ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int ContactId)
        {
            Contact entity = repository.GetById(ContactId);
            if (entity != null)
            {
                repository.Delete(entity);
                repository.Save();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult MarkAsRead(int ContactId, bool isRead)
        {
            Contact entity = repository.GetById(ContactId);
            entity.isRead = isRead;
            repository.Save();
            return RedirectToAction("Index");
        }
    }
}