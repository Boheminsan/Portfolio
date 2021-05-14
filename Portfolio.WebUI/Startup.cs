using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Portfolio.Data.Abstract;
using Portfolio.Data.Concrete.EFCore;
using Portfolio.WebUI.Models;

namespace Portfolio.WebUI {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddControllersWithViews ();
            services.AddDbContext<PortfolioContext> (options => options.UseSqlServer (Configuration.GetConnectionString ("DefaultConnection"), b => b.MigrationsAssembly ("Portfolio.WebUI")));
            services.ConfigureApplicationCookie (opt => opt.LoginPath = "/Admin/Login");
            services.AddDbContext<ApplicationIdentityDbContext> (options => options.UseSqlServer (Configuration.GetConnectionString ("DefaultConnection"), b => b.MigrationsAssembly ("Portfolio.WebUI")));
            services.AddIdentity<ApplicationUser, IdentityRole> ()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext> ()
                .AddDefaultTokenProviders ();
            services.AddScoped<ICategoryRepository, EFCategoryRepository> ();
            services.AddScoped<IContactRepository, EFContactRepository> ();
            services.AddScoped<IImageRepository, EFImageRepository> ();
            services.AddScoped<IMenuItemRepository, EFMenuItemRepository> ();
            services.AddScoped<IProjectRepository, EFProjectRepository> ();
            services.AddScoped<IServiceRepository, EFServiceRepository> ();
            services.AddScoped<ISliderRepository, EFSliderRepository> ();
            services.AddScoped<ITestimonialRepository, EFTestimonialRepository> ();
            services.AddScoped<IFooterRepository, EFFooterRepository> ();
            services.AddScoped<IUnitOfWork, EFUnitOfWork> ();
            services.AddSingleton<IFileProvider> (new PhysicalFileProvider (
                Path.Combine (Directory.GetCurrentDirectory (), "wwwroot")));
            services.Configure<RazorViewEngineOptions> (o => {
                o.ViewLocationFormats.Add ("/Views/Admin/{1}/{0}" + RazorViewEngine.ViewExtension);
                //o.ViewLocationFormats.Add ("/MyViewsFolder/Shared/{0}" + RazorViewEngine.ViewExtension);
                services.AddMvc ();

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseExceptionHandler ("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts ();
            }
            app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            app.UseStaticFiles (new StaticFileOptions {
                FileProvider = new PhysicalFileProvider (
                        Path.Combine (env.ContentRootPath, "node_modules")),
                    RequestPath = "/modules"
            });
            app.UseRouting ();
            app.UseStatusCodePages ();
            app.UseAuthentication ();
            app.UseAuthorization ();
            // app.UseMvc ();
            app.UseEndpoints (endpoints => {
                endpoints.MapControllerRoute (
                    name: "download",
                    pattern: "/DownloadCV/filename",
                    new { controller = "Home", action = "DownloadCV" }
                );
                endpoints.MapControllerRoute (
                    name: "projects",
                    pattern: "Projects/{action=Done}/{id?}",
                    new { controller = "Projects" });
                endpoints.MapControllerRoute (
                    name: "Admin",
                    pattern: "Admin/{controller}/{action=Index}/{id?}");
                endpoints.MapControllerRoute (
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");
            });

            SeedData.EnsurePopulated (app);
        }
    }
}