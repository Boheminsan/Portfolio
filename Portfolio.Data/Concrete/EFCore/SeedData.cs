using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore {
    public static class SeedData {
        public static void EnsurePopulated (IApplicationBuilder app) {
            var context = app.ApplicationServices.GetRequiredService<PortfolioContext> ();
            context.Database.Migrate ();
            if (!context.MenuItems.Any ()) {
                var menu = new List<MenuItem> {
                    new MenuItem () { MenuItemName = "Anasayfa", Link = "/" },
                    new MenuItem () { MenuItemName = "Projeler", Link = "#" },
                    new MenuItem () { MenuItemName = "İletişim", Link = "/Home/contact" },
                    new MenuItem () { MenuItemName = "Hakkımda", Link = "/Home/about" }
                };
                context.MenuItems.AddRange (menu);
            }
            if (!context.SubMenus.Any ()) {
                var sub = new List<SubMenu> {
                    new SubMenu () { SubMenuName = "Yapılmış", Link = "/Project/done", MenuItemId = 3 },
                    new SubMenu () { SubMenuName = "Taslak", Link = "/Project/draft", MenuItemId = 3 },
                };
                context.SubMenus.AddRange (sub);
            }

            if (!context.Categories.Any ()) {
                var categories = new List<Category> {
                    new Category () {
                    CategoryName = "Web", CType = CategoryType.Tech, Filter = ".web"
                    },
                    new Category () {
                    CategoryName = "Masaüstü", CType = CategoryType.Tech, Filter = ".desktop"
                    },
                    new Category () {
                    CategoryName = "Makine Öğrenmesi", CType = CategoryType.Tech, Filter = ".machine"
                    },
                    new Category () {
                    CategoryName = "Diğer", CType = CategoryType.Tech, Filter = ".etc"
                    },
                    new Category () {
                    CategoryName = "C#", CType = CategoryType.Lang, Filter = ".cs"
                    },
                    new Category () {
                    CategoryName = "Python", CType = CategoryType.Lang, Filter = ".py"
                    },
                    new Category () {
                    CategoryName = "JS/JQ", CType = CategoryType.Lang, Filter = ".js"
                    },
                    new Category () {
                    CategoryName = "PHP", CType = CategoryType.Lang, Filter = ".php"
                    },
                    new Category () {
                    CategoryName = "Diğer Diller", CType = CategoryType.Lang, Filter = ".etclang"
                    }
                };
                context.Categories.AddRange (categories);
            }

            if (!context.Projects.Any ()) {
                var projects = new List<Project> {
                    new Project () {
                    Title = "Proje1", CoverImage = "prt1.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", Images = new List<Image> {
                    new Image () { ImageName = "prt1.jpg", FullPath = "assets\\img\\portfolio\\" },
                    new Image () { ImageName = "prt2.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt3.jpg", FullPath = "assets\\img\\portfolio" }
                    }
                    },
                    new Project () {
                    Title = "Proje2", CoverImage = "prt4.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", Images = new List<Image> {
                    new Image () { ImageName = "prt4.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt5.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt6.jpg", FullPath = "assets\\img\\portfolio" }
                    }
                    },
                    new Project () {
                    Title = "Proje3", CoverImage = "prt7.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", Images = new List<Image> {
                    new Image () { ImageName = "prt7.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt8.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt9.jpg", FullPath = "assets\\img\\portfolio" }
                    }
                    },
                    new Project () {
                    Title = "Proje4", CoverImage = "prt10.jpg", isDone = false, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", Images = new List<Image> {
                    new Image () { ImageName = "prt10.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt11.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt12.jpg", FullPath = "assets\\img\\portfolio" }
                    }
                    },
                    new Project () {
                    Title = "Proje5", CoverImage = "prt13.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", Images = new List<Image> {
                    new Image () { ImageName = "prt13.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt14.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt15.jpg", FullPath = "assets\\img\\portfolio" }
                    }
                    },
                    new Project () {
                    Title = "Proje6", CoverImage = "prt16.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", Images = new List<Image> {
                    new Image () { ImageName = "prt16.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt17.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt18.jpg", FullPath = "assets\\img\\portfolio" }
                    }
                    },
                    new Project () {
                    Title = "Proje7", CoverImage = "prt19.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", Images = new List<Image> {
                    new Image () { ImageName = "prt19.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt20.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt21.jpg", FullPath = "assets\\img\\portfolio" }
                    }
                    },
                    new Project () {
                    Title = "Proje8", CoverImage = "prt22.jpg", isDone = false, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", Images = new List<Image> {
                    new Image () { ImageName = "prt22.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt23.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt24.jpg", FullPath = "assets\\img\\portfolio" }
                    }
                    },
                    new Project () {
                    Title = "Proje9", CoverImage = "prt25.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", Images = new List<Image> {
                    new Image () { ImageName = "prt25.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt26.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt27.jpg", FullPath = "assets\\img\\portfolio" }
                    }
                    },
                    new Project () {
                    Title = "Proje10", CoverImage = "prt28.jpg", isDone = false, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", Images = new List<Image> {
                    new Image () { ImageName = "prt28.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt29.jpg", FullPath = "assets\\img\\portfolio" },
                    new Image () { ImageName = "prt30.jpg", FullPath = "assets\\img\\portfolio" }
                    }
                    }
                };
                context.Projects.AddRange (projects);
            }

            if (!context.Sliders.Any ()) {
                var sImages = new List<Slider> {
                    new Slider () { Image = new Image { ImageName = "ide1.png", FullPath = "assets\\img\\ides" }, isHome = true },
                    new Slider () { Image = new Image { ImageName = "ide2.png", FullPath = "assets\\img\\ides" }, isHome = false },
                    new Slider () { Image = new Image { ImageName = "ide3.png", FullPath = "assets\\img\\ides" }, isHome = true },
                    new Slider () { Image = new Image { ImageName = "ide4.png", FullPath = "assets\\img\\ides" }, isHome = true },
                    new Slider () { Image = new Image { ImageName = "ide5.png", FullPath = "assets\\img\\ides" }, isHome = false },
                    new Slider () { Image = new Image { ImageName = "ide6.png", FullPath = "assets\\img\\ides" }, isHome = true },
                    new Slider () { Image = new Image { ImageName = "ide7.png", FullPath = "assets\\img\\ides" }, isHome = true },
                    new Slider () { Image = new Image { ImageName = "ide8.png", FullPath = "assets\\img\\ides" }, isHome = true },
                    new Slider () { Image = new Image { ImageName = "ide9.png", FullPath = "assets\\img\\ides" }, isHome = true },
                    new Slider () { Image = new Image { ImageName = "ide10.png", FullPath = "assets\\img\\ides" }, isHome = false },
                    new Slider () { Image = new Image { ImageName = "ide11.png", FullPath = "assets\\img\\ides" }, isHome = true },
                    new Slider () { Image = new Image { ImageName = "ide12.png", FullPath = "assets\\img\\ides" }, isHome = true },
                    new Slider () { Image = new Image { ImageName = "ide13.png", FullPath = "assets\\img\\ides" }, isHome = true },
                    new Slider () { Image = new Image { ImageName = "ide14.png", FullPath = "assets\\img\\ides" }, isHome = false },
                    new Slider () { Image = new Image { ImageName = "ide15.png", FullPath = "assets\\img\\ides" }, isHome = true }
                };
                context.Sliders.AddRange (sImages);
            }
            if (!context.Services.Any ()) {
                var services = new List<Service> {
                    new Service () { Title = "Makine öğrenmesi", Image = new Image { ImageName = "ml.png", FullPath = "assets\\img\\services" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Service () { Title = "Title2", Image = new Image { ImageName = "laptop.png", FullPath = "assets\\img\\services" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = false },
                    new Service () { Title = "Title3", Image = new Image { ImageName = "cscience.png", FullPath = "assets\\img\\services" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Service () { Title = "Title4", Image = new Image { ImageName = "windows.png", FullPath = "assets\\img\\services" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Service () { Title = "Title5", Image = new Image { ImageName = "network.png", FullPath = "assets\\img\\services" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = false },
                    new Service () { Title = "Title6", Image = new Image { ImageName = "ml.png", FullPath = "assets\\img\\services" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true }
                };
                context.Services.AddRange (services);
            }
            if (!context.Contacts.Any ()) {
                var contact = new [] {
                    new Contact () {
                    Name = "Ali Pınar",
                    Mail = "yazarbozar6969@hmail.com",
                    Title = "Naptın kanka",
                    Text = "Consectetur adipisicing elit. Modi veniam dignissimos omnis repudiandae quis ipsum at beatae obcaecati, saepe facere.",
                    isRead = false
                    },
                    new Contact () {
                    Name = "Ali Sınar",
                    Mail = "yazbozar6969@hmail.com",
                    Title = "Nördün kanka",
                    Text = "Consecteur adi pislicking elit. Modi veniam dignissimos omnis repudiandae quis ipsum at beatae obcaecati, saepe facere.",
                    isRead = false
                    },
                    new Contact () {
                    Name = "Eli Kınar",
                    Mail = "daldazak6868@hmail.com",
                    Title = "Gördüm kanka",
                    Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Rerum sequi totam corporis culpa sed neque! Modi veniam dignissimos omnis repudiandae quis ipsum at beatae obcaecati, saepe facere.",
                    isRead = false
                    }
                };
                context.Contacts.AddRange (contact);
            }
            if (!context.Testimonials.Any ()) {

                var test = new [] {
                    new Testimonial () { Title = "Title1", Image = new Image { ImageName = "client1.jpg", FullPath = "assets\\img\\clients" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Testimonial () { Title = "Title2", Image = new Image { ImageName = "client2.jpg", FullPath = "assets\\img\\clients" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = false },
                    new Testimonial () { Title = "Title3", Image = new Image { ImageName = "client3.jpg", FullPath = "assets\\img\\clients" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Testimonial () { Title = "Title4", Image = new Image { ImageName = "client4.jpg", FullPath = "assets\\img\\clients" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Testimonial () { Title = "Title5", Image = new Image { ImageName = "client5.jpg", FullPath = "assets\\img\\clients" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = false },
                    new Testimonial () { Title = "Title6", Image = new Image { ImageName = "client6.jpg", FullPath = "assets\\img\\clients" }, Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = false }
                };
                context.Testimonials.AddRange (test);
            }
            if (!context.Footers.Any ()) {
                var footer = new [] {
                    new Footer {
                    Icon = "fab fa-facebook-square",
                    Link = "#",
                    Order = 1,
                    SocialMediaName = "Facebook"
                    },
                    new Footer {
                    Icon = "fab fa-twitter-square",
                    Link = "#",
                    Order = 2,
                    SocialMediaName = "Twitter"
                    },
                    new Footer {
                    Icon = "fab fa-instagram",
                    Link = "#",
                    Order = 3,
                    SocialMediaName = "Instagram"
                    },
                    new Footer {
                    Icon = "fab fa-github",
                    Link = "#",
                    Order = 4,
                    SocialMediaName = "Github"
                    },
                    new Footer {
                    Icon = "fab fa-kaggle",
                    Link = "#",
                    Order = 5,
                    SocialMediaName = "Kaggle"
                    },
                    new Footer {
                    Icon = "fab fa-linkedin-in",
                    Link = "#",
                    Order = 6,
                    SocialMediaName = "LinkedIn"
                    }
                };
                context.Footers.AddRange (footer);
            }
            context.SaveChanges ();
        }
    }
}