using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore {
    public class EFMenuItemRepository : EFGenericRepository<MenuItem>, IMenuItemRepository {
        public EFMenuItemRepository (PortfolioContext context) : base (context) { }
        public PortfolioContext PortfolioContext {
            get { return context as PortfolioContext; }
        }
    }
}