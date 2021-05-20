using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore
{
    public class EFServiceRepository : EFGenericRepository<Service>, IServiceRepository
    {
        public EFServiceRepository(PortfolioContext context) : base(context) { }
        public PortfolioContext PortfolioContext
        {
            get { return context as PortfolioContext; }
        }
    }
}