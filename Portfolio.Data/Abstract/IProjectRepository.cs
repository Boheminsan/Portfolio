using Portfolio.Entity;

namespace Portfolio.Data.Abstract
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        void DeleteById(int portId);
    }
}