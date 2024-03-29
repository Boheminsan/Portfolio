using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore
{
    public class EFImageRepository : EFGenericRepository<Image>, IImageRepository
    {
        public EFImageRepository(PortfolioContext context) : base(context) { }
        public PortfolioContext PortfolioContext
        {
            get { return context as PortfolioContext; }
        }
    }
}