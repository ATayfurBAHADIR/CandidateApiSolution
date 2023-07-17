using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Service
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly Context _dbContext;

        protected Repository(Context context)
        {
            _dbContext = context;
        }
        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public IEnumerable<T> Filter(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(Guid Id)
        {
            return _dbContext.Set<T>().Find(Id);
        }

        public void Remove(Guid Id)
        {
            _dbContext.Set<T>().Remove(GetById(Id));
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }
    }
}
