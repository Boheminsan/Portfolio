using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI.Controllers {
    public class AdminController : Controller {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        public AdminController (UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager) {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        [Authorize]
        public IActionResult Index () {
            return View ();
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync (RegisterModel model) {
            if (ModelState.IsValid) {
                ApplicationUser user = new ApplicationUser ();
                user.UserName = model.UserName;
                user.Email = model.Email;
                var result = await userManager.CreateAsync (user, model.Password);
                if (result.Succeeded) {
                    return RedirectToAction ("Index");
                } else {
                    foreach (var item in result.Errors) {
                        ModelState.AddModelError ("", item.Description);
                    }
                }
            }
            return View (model);
        }

    }
}