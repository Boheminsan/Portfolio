using System;
using Portfolio.Data.Abstract;

namespace Portfolio.Data.Concrete.EFCore {
    public class EFUnitOfWork : IUnitOfWork {
        private readonly PortfolioContext dbContext;
        public EFUnitOfWork (PortfolioContext _dbContext) {
            dbContext = _dbContext??throw new ArgumentNullException ();
        }

        ICategoryRepository _categories;
        IContactRepository _contacts;
        IMenuItemRepository _menuitems;
        IProjectRepository _projects;
        IServiceRepository _services;
        ISliderRepository _sliders;
        IImageRepository _images;
        ITestimonialRepository _testimonials;
        public IProjectRepository Projects {
            get {
                return _projects??(_projects = new EFProjectRepository (dbContext));
            }
        }

        public ICategoryRepository Categories {
            get {
                return _categories??(_categories = new EFCategoryRepository (dbContext));
            }
        }

        public IContactRepository Contacts {
            get {
                return _contacts??(_contacts = new EFContactRepository (dbContext));
            }
        }
        public IMenuItemRepository MenuItems {
            get {
                return _menuitems??(_menuitems = new EFMenuItemRepository (dbContext));
            }
        }

        public IServiceRepository Services {
            get {
                return _services??(_services = new EFServiceRepository (dbContext));
            }
        }

        public ISliderRepository Sliders {
            get {
                return _sliders??(_sliders = new EFSliderRepository (dbContext));
            }
        }
        public ITestimonialRepository Testimonials {
            get {
                return _testimonials??(_testimonials = new EFTestimonialRepository (dbContext));
            }
        }
        public IImageRepository Images {
            get {
                return _images??(_images = new EFImageRepository (dbContext));
            }
        }
        public void Dispose () {
            dbContext.Dispose ();
        }

        public int SaveChanges () {
            try {
                return dbContext.SaveChanges ();
            } catch (Exception) {

                throw;
            }
        }
    }
}