using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _dbContext;
        public ICustomerRepository _customer { get; }
        public ITransactionRepository _transaction { get; }
        public UnitOfWork(Context dbContext,
                           ICustomerRepository customer, ITransactionRepository transaction)
        {
            _dbContext = dbContext;
            _customer = customer;
            _transaction = transaction;
        }
        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
