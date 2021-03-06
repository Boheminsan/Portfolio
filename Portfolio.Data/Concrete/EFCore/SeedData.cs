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
            if (!context.MyProjects.Any () || !context.SliderImages.Any () || !context.Categories.Any ()) {
                var projects = new [] {
                    //kategorileri ekle
                    new Project () {
                    Title = "Proje1", Image = "prt1.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", CategoryList = new List<Category> () {
                    new Category {
                    CategoryName = "Web", CType = CategoryType.Tech, Filter = ".web"
                    },
                    new Category {
                    CategoryName = "JS/JQ", CType = CategoryType.Tech, Filter = ".js"
                    }
                    }
                    },
                    new Project () {
                    Title = "Proje2", Image = "prt2.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", CategoryList = new List<Category> () {
                    new Category {
                    CategoryName = "Machine Learning", CType = CategoryType.Lang, Filter = ".machine"
                    },
                    new Category {
                    CategoryName = "Python", CType = CategoryType.Lang, Filter = ".py"
                    }
                    }
                    },
                    new Project () {
                    Title = "Proje3", Image = "prt3.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", CategoryList = new List<Category> () {
                    new Category {
                    CategoryName = "Web", CType = CategoryType.Tech, Filter = ".web"
                    },
                    new Category {
                    CategoryName = "JS/JQ", CType = CategoryType.Lang, Filter = ".js"
                    },
                    new Category {
                    CategoryName = "PHP", CType = CategoryType.Lang, Filter = ".php"
                    }
                    }
                    },
                    new Project () {
                    Title = "Proje4", Image = "prt4.jpg", isDone = false, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", CategoryList = new List<Category> () {
                    new Category {
                    CategoryName = "Web", CType = CategoryType.Tech, Filter = ".web"
                    },
                    new Category {
                    CategoryName = "Di??er", CType = CategoryType.Tech, Filter = ".etc"
                    },
                    new Category {
                    CategoryName = "Di??er", CType = CategoryType.Lang, Filter = ".etclang"
                    },
                    new Category {
                    CategoryName = "JS/JQ", CType = CategoryType.Lang, Filter = ".js"
                    }
                    }
                    },
                    new Project () {
                    Title = "Proje5", Image = "prt5.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", CategoryList = new List<Category> () {
                    new Category {
                    CategoryName = "Data", CType = CategoryType.Tech, Filter = ".web"
                    },
                    new Category {
                    CategoryName = "Di??er", CType = CategoryType.Lang, Filter = ".etclang"
                    }
                    }
                    },
                    new Project () {
                    Title = "Proje6", Image = "prt6.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", CategoryList = new List<Category> () {
                    new Category {
                    CategoryName = "Web", CType = CategoryType.Tech, Filter = ".web"
                    },
                    new Category {
                    CategoryName = "Makine ????renmesi", CType = CategoryType.Tech, Filter = ".machine"
                    },
                    new Category {
                    CategoryName = "Python", CType = CategoryType.Lang, Filter = ".py"
                    }
                    }
                    },
                    new Project () {
                    Title = "Proje7", Image = "prt7.jpg", isDone = false, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", CategoryList = new List<Category> () {
                    new Category {
                    CategoryName = "Data", CType = CategoryType.Tech, Filter = ".data"
                    },
                    new Category {
                    CategoryName = "Di??er", CType = CategoryType.Tech, Filter = ".etc"
                    },
                    new Category {
                    CategoryName = "C#", CType = CategoryType.Lang, Filter = ".cs"
                    }
                    }
                    },
                    new Project () {
                    Title = "Proje8", Image = "prt8.jpg", isDone = false, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", CategoryList = new List<Category> () {
                    new Category {
                    CategoryName = "Web", CType = CategoryType.Tech, Filter = ".web"
                    },
                    new Category {
                    CategoryName = "Di??er", CType = CategoryType.Tech, Filter = ".etc"
                    },
                    new Category {
                    CategoryName = "PHP", CType = CategoryType.Lang, Filter = ".php"
                    }
                    }
                    },
                    new Project () {
                    Title = "Proje9", Image = "prt9.jpg", isDone = true, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", CategoryList = new List<Category> () {
                    new Category {
                    CategoryName = "Data", CType = CategoryType.Tech, Filter = ".data"
                    },
                    new Category {
                    CategoryName = "Makine ????renmesi", CType = CategoryType.Tech, Filter = ".machine"
                    },
                    new Category {
                    CategoryName = "Python", CType = CategoryType.Lang, Filter = ".py"
                    }
                    }
                    },
                    new Project () {
                    Title = "Proje10", Image = "prt10.jpg", isDone = false, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente quibusdam ipsum repellat rem architecto omnis dolorum ex? Quam, maiores eum.", CategoryList = new List<Category> () {
                    new Category {
                    CategoryName = "Data", CType = CategoryType.Tech, Filter = ".data"
                    },
                    new Category {
                    CategoryName = "Makine ????renmesi", CType = CategoryType.Tech, Filter = ".machine"
                    },
                    new Category {
                    CategoryName = "C#", CType = CategoryType.Lang, Filter = ".cs"
                    }
                    }
                    }
                };
                context.MyProjects.AddRange (projects);

                //images ??o??ul olunca
                var images = new Image[] {
                    new Image () { ImageName = "Project1_1.jpg", Project = projects[0] },
                    new Image () { ImageName = "Project1_2.jpg", Project = projects[0] },
                    new Image () { ImageName = "Project1_3.jpg", Project = projects[0] },
                    new Image () { ImageName = "Project1_4.jpg", Project = projects[0] },

                    new Image () { ImageName = "Project2_1.jpg", Project = projects[1] },
                    new Image () { ImageName = "Project2_2.jpg", Project = projects[1] },
                    new Image () { ImageName = "Project2_3.jpg", Project = projects[1] },
                    new Image () { ImageName = "Project2_4.jpg", Project = projects[1] },

                    new Image () { ImageName = "Project3_1.jpg", Project = projects[2] },
                    new Image () { ImageName = "Project3_2.jpg", Project = projects[2] },
                    new Image () { ImageName = "Project3_3.jpg", Project = projects[2] },
                    new Image () { ImageName = "Project3_4.jpg", Project = projects[2] },

                    new Image () { ImageName = "Project4_1.jpg", Project = projects[3] },
                    new Image () { ImageName = "Project4_2.jpg", Project = projects[3] },
                    new Image () { ImageName = "Project4_3.jpg", Project = projects[3] },
                    new Image () { ImageName = "Project4_4.jpg", Project = projects[3] },

                    new Image () { ImageName = "Project5_1.jpg", Project = projects[4] },
                    new Image () { ImageName = "Project5_2.jpg", Project = projects[4] },
                    new Image () { ImageName = "Project5_3.jpg", Project = projects[4] },
                    new Image () { ImageName = "Project5_4.jpg", Project = projects[4] },

                    new Image () { ImageName = "Project6_1.jpg", Project = projects[5] },
                    new Image () { ImageName = "Project6_2.jpg", Project = projects[5] },
                    new Image () { ImageName = "Project6_3.jpg", Project = projects[5] },
                    new Image () { ImageName = "Project6_4.jpg", Project = projects[5] },

                    new Image () { ImageName = "Project7_1.jpg", Project = projects[6] },
                    new Image () { ImageName = "Project7_2.jpg", Project = projects[6] },
                    new Image () { ImageName = "Project7_3.jpg", Project = projects[6] },
                    new Image () { ImageName = "Project7_4.jpg", Project = projects[6] },

                    new Image () { ImageName = "Project8_1.jpg", Project = projects[7] },
                    new Image () { ImageName = "Project8_2.jpg", Project = projects[7] },
                    new Image () { ImageName = "Project8_3.jpg", Project = projects[7] },
                    new Image () { ImageName = "Project8_4.jpg", Project = projects[7] },

                    new Image () { ImageName = "Project9_1.jpg", Project = projects[8] },
                    new Image () { ImageName = "Project9_2.jpg", Project = projects[8] },
                    new Image () { ImageName = "Project9_3.jpg", Project = projects[8] },
                    new Image () { ImageName = "Project9_4.jpg", Project = projects[8] },

                    new Image () { ImageName = "Project10_1.jpg", Project = projects[9] },
                    new Image () { ImageName = "Project10_2.jpg", Project = projects[9] },
                    new Image () { ImageName = "Project10_3.jpg", Project = projects[9] },
                    new Image () { ImageName = "Project10_4.jpg", Project = projects[9] },
                };
                context.Images.AddRange (images);
                var categories = new [] {
                    new Category () {
                    CategoryName = "Web", CType = CategoryType.Tech, Filter = ".web"
                    },
                    new Category () {
                    CategoryName = "Masa??st??", CType = CategoryType.Tech, Filter = ".desktop"
                    },
                    new Category () {
                    CategoryName = "Makine ????renmesi", CType = CategoryType.Tech, Filter = ".machine"
                    },
                    new Category () {
                    CategoryName = "Di??er", CType = CategoryType.Tech, Filter = ".etc"
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
                    CategoryName = "Di??er Diller", CType = CategoryType.Lang, Filter = ".etclang"
                    }
                };
                context.Categories.AddRange (categories);
            }

            if (!context.MenuItems.Any ()) {
                var menu = new [] {
                    new MenuItem () {
                    MenuItemName = "Anasayfa",
                    Link = "/"
                    },
                    new MenuItem () {
                    MenuItemName = "Hakk??mda",
                    Link = "/Home/about"
                    },
                    new MenuItem () {
                    MenuItemName = "Projeler",
                    Link = "#",
                    },
                    new MenuItem () {
                    MenuItemName = "Yap??lm????",
                    Link = "/Project/done",
                    ParentId = 4
                    },
                    new MenuItem () {
                    MenuItemName = "Taslak",
                    Link = "/Project/draft",
                    ParentId = 4
                    },
                    new MenuItem () {
                    MenuItemName = "??leti??im",
                    Link = "/Home/contact"
                    }
                };
                context.MenuItems.AddRange (menu);
            }

            if (!context.SliderImages.Any ()) {
                var sImages = new [] {
                    new Slider () { Image = "ide1.png", isHome = true },
                    new Slider () { Image = "ide2.png", isHome = false },
                    new Slider () { Image = "ide3.png", isHome = true },
                    new Slider () { Image = "ide4.png", isHome = true },
                    new Slider () { Image = "ide5.png", isHome = false },
                    new Slider () { Image = "ide6.png", isHome = true },
                    new Slider () { Image = "ide7.png", isHome = true },
                    new Slider () { Image = "ide8.png", isHome = true },
                    new Slider () { Image = "ide9.png", isHome = true },
                    new Slider () { Image = "ide10.png", isHome = false },
                    new Slider () { Image = "ide11.png", isHome = true },
                    new Slider () { Image = "ide12.png", isHome = true },
                    new Slider () { Image = "ide13.png", isHome = true },
                    new Slider () { Image = "ide14.png", isHome = false },
                    new Slider () { Image = "ide15.png", isHome = true }
                };
                context.SliderImages.AddRange (sImages);

            }
            if (!context.Services.Any ()) {
                var services = new [] {
                    new Service () { Title = "Title1", Image = "service1.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Service () { Title = "Title2", Image = "service2.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = false },
                    new Service () { Title = "Title3", Image = "service3.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Service () { Title = "Title4", Image = "service4.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Service () { Title = "Title5", Image = "service5.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = false },
                    new Service () { Title = "Title6", Image = "service6.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true }
                };
                context.Services.AddRange (services);
            }
            if (!context.Testimonials.Any ()) {

                var test = new [] {
                    new Testimonial () { Title = "Title1", Image = "client1.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Testimonial () { Title = "Title2", Image = "client2.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = false },
                    new Testimonial () { Title = "Title3", Image = "client3.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Testimonial () { Title = "Title4", Image = "client4.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = true },
                    new Testimonial () { Title = "Title5", Image = "client5.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = false },
                    new Testimonial () { Title = "Title6", Image = "client6.jpg", Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla beatae illo a deserunt omnis maxime, aperiam eius fugit nobis ut!", isHome = false }
                };
                context.Testimonials.AddRange (test);
            }
            context.SaveChanges ();
        }
    }
}