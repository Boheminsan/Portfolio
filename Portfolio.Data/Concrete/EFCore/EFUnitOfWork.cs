using Portfolio.Data.Abstract;
using System;

namespace Portfolio.Data.Concrete.EFCore
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly PortfolioContext dbContext;
        public EFUnitOfWork(PortfolioContext _dbContext)
        {
            dbContext = _dbContext ?? throw new ArgumentNullException();
        }

        private ICategoryRepository _categories;
        private IContactRepository _contacts;
        private IMenuItemRepository _menuitems;
        private IProjectRepository _projects;
        private IServiceRepository _services;
        private ISliderRepository _sliders;
        private IImageRepository _images;
        private IFooterRepository _footers;
        private ITestimonialRepository _testimonials;
        public IProjectRepository Projects
        {
            get
            {
                return _projects ?? (_projects = new EFProjectRepository(dbContext));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EFCategoryRepository(dbContext));
            }
        }

        public IContactRepository Contacts
        {
            get
            {
                return _contacts ?? (_contacts = new EFContactRepository(dbContext));
            }
        }
        public IMenuItemRepository MenuItems
        {
            get
            {
                return _menuitems ?? (_menuitems = new EFMenuItemRepository(dbContext));
            }
        }

        public IServiceRepository Services
        {
            get
            {
                return _services ?? (_services = new EFServiceRepository(dbContext));
            }
        }

        public ISliderRepository Sliders
        {
            get
            {
                return _sliders ?? (_sliders = new EFSliderRepository(dbContext));
            }
        }
        public ITestimonialRepository Testimonials
        {
            get
            {
                return _testimonials ?? (_testimonials = new EFTestimonialRepository(dbContext));
            }
        }
        public IImageRepository Images
        {
            get
            {
                return _images ?? (_images = new EFImageRepository(dbContext));
            }
        }
        public IFooterRepository Footers
        {
            get
            {
                return _footers ?? (_footers = new EFFooterRepository(dbContext));
            }
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
                return dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}