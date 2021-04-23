using Microsoft.AspNetCore.Mvc;

namespace Portfolio.WebUI.Controllers {
    public class AdminController : Controller {

        public IActionResult Index () {
            return View ();
        }
    }
}