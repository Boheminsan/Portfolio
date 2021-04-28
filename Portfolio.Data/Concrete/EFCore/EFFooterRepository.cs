using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore {
    public class EFFooterRepository : EFGenericRepository<Footer>, IFooterRepository {
        public EFFooterRepository (PortfolioContext context) : base (context) { }
        public PortfolioContext PortfolioContext {
            get { return context as PortfolioContext; }
        }
    }
}