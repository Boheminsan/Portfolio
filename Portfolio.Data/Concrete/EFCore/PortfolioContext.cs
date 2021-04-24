using Microsoft.EntityFrameworkCore;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore {
    public class PortfolioContext : DbContext {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public PortfolioContext (DbContextOptions<PortfolioContext> options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<Project> ()
                .HasMany (i => i.Images)
                .WithOne (p => p.Project);

            modelBuilder.Entity<Slider> ()
                .HasOne (a => a.Image)
                .WithOne (b => b.Slider);

            modelBuilder.Entity<Testimonial> ()
                .HasOne (a => a.Image)
                .WithOne (b => b.Testimonial);

            modelBuilder.Entity<Service> ()
                .HasOne (a => a.Image)
                .WithOne (b => b.Service);

            modelBuilder.Entity<ProjectCategory> ()
                .HasKey (pc => new { pc.ProjectId, pc.CategoryId });
            modelBuilder.Entity<ProjectCategory> ()
                .HasOne<Project> (pc => pc.Project)
                .WithMany (s => s.ProjectCategories)
                .HasForeignKey (pc => pc.ProjectId);

            modelBuilder.Entity<ProjectCategory> ()
                .HasOne<Category> (pc => pc.Category)
                .WithMany (s => s.ProjectCategories)
                .HasForeignKey (pc => pc.CategoryId);
        }
    }
}