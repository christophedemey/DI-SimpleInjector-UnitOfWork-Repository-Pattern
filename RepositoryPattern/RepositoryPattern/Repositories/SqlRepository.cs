using RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class SqlRepository<T> : IRepository<T> where T : class
    {
        private DbContext _entities = null;
        
        public void Setup(DbContext context)
        {
            _entities = context;    
        }

        public void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public void Commit()
        {
            _entities.SaveChanges();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public void Remove(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }
    }
}
