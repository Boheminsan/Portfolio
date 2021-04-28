using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore {
    public class EFImageRepository : EFGenericRepository<Image>, IImageRepository {
        public EFImageRepository (PortfolioContext context) : base (context) { }
        public PortfolioContext PortfolioContext {
            get { return context as PortfolioContext; }
        }
        public List<Image> GetFolder (string Path) {
            var folder = PortfolioContext.Images.Where (p => p.Path == Path).ToList ();
            return folder;
        }
    }
}