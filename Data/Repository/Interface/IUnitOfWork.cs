using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository _customer { get; }
        int Save();
    }
}
