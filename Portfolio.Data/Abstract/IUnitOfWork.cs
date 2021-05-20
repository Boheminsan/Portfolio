using System;

namespace Portfolio.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository Projects { get; }
        ICategoryRepository Categories { get; }
        IContactRepository Contacts { get; }
        IImageRepository Images { get; }
        IMenuItemRepository MenuItems { get; }
        IServiceRepository Services { get; }
        ISliderRepository Sliders { get; }
        ITestimonialRepository Testimonials { get; }
        IFooterRepository Footers { get; }
        int SaveChanges();
    }
}