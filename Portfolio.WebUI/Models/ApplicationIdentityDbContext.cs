using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.WebUI.Models {
    public class ApplicationIdentityDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationIdentityDbContext (DbContextOptions<ApplicationIdentityDbContext> options) : base (options) {

        }
    }
}