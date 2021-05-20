using Portfolio.Data.Abstract;
using Portfolio.Entity;
using System.Linq;

namespace Portfolio.Data.Concrete.EFCore
{
    public class EFCategoryRepository : EFGenericRepository<Category>, ICategoryRepository
    {
        public EFCategoryRepository(PortfolioContext context) : base(context) { }
        public PortfolioContext PortfolioContext
        {
            get { return context as PortfolioContext; }
        }
        public void DeleteCategory(int catid)
        {
            var category = PortfolioContext.Categories.FirstOrDefault(p => p.CategoryId == catid);
            if (category != null)
            {
                PortfolioContext.Categories.Remove(category);
                PortfolioContext.SaveChanges();
            }
        }

        public void Save2(Category entity)
        {
            if (entity.CategoryId == 0)
            {
                Add(entity);
            }
            else
            {
                Edit(entity);
            }
        }
    }
}