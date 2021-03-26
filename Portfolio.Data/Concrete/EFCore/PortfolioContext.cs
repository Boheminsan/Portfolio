using Microsoft.EntityFrameworkCore;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore {
    public class PortfolioContext : DbContext {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Slider> SliderImages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        // public DbSet<Image> Images { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public PortfolioContext (DbContextOptions<PortfolioContext> options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<ProjectCategory> ().HasKey (pk => new { pk.ProjectId, pk.CategoryId });
        }
    }
}