using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore
{
    public class EFTestimonialRepository : EFGenericRepository<Testimonial>, ITestimonialRepository
    {
        public EFTestimonialRepository(PortfolioContext context) : base(context) { }
        public PortfolioContext PortfolioContext
        {
            get { return context as PortfolioContext; }
        }
    }
}