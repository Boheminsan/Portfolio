using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Portfolio.Data.Abstract {
    public interface IGenericRepository<T> where T : class {
        T GetById (int id);
        IQueryable<T> GetAll ();
        IQueryable<T> Find (Expression<Func<T, bool>> predicate);
        void Add (T entity);
        void Delete (T entity);
        void Edit (T entity);
        void Save ();

    }
}