using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Abstract;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Portfolio.Data.Concrete.EFCore
{
    public class EFGenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext context;
        public EFGenericRepository(DbContext ctx)
        {
            context = ctx;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            var result = context.Set<T>().Where(predicate);
            return result;
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public T GetById(int id)
        {
            var result = context.Set<T>().Find(id);
            return result;
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}