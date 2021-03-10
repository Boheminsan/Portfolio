using System.Linq;
using Portfolio.Entity;

namespace Portfolio.Data.Abstract {
    public interface ICategoryRepository : IGenericRepository<Category> {
        void DeleteCategory (int catid);
        void Save2 (Category entity);
    }
}