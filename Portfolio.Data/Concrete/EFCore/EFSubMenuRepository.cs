using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore {
    public class EFSubMenuRepository : EFGenericRepository<SubMenu>, ISubMenuRepository {
        public EFSubMenuRepository (PortfolioContext context) : base (context) { }
        public PortfolioContext PortfolioContext {
            get { return context as PortfolioContext; }
        }
    }
}