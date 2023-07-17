using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        T GetById(Guid Id);
        IEnumerable<T> Filter(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Remove(Guid Id);
    }
}
