using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore {
    public class EFContactRepository : EFGenericRepository<Contact>, IContactRepository {
        public EFContactRepository (PortfolioContext context) : base (context) { }
        public PortfolioContext PortfolioContext {
            get { return context as PortfolioContext; }
        }
    }
}