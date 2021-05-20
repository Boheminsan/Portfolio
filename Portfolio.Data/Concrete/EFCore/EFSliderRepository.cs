using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore
{
    public class EFSliderRepository : EFGenericRepository<Slider>, ISliderRepository
    {
        public EFSliderRepository(PortfolioContext context) : base(context) { }
        public PortfolioContext PortfolioContext
        {
            get { return context as PortfolioContext; }
        }
    }
}