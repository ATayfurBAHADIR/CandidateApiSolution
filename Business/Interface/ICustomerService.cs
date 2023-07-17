using Business.Dto;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface ICustomerService
    {
        void AddCustomer(CustomerRequest customer);
    }
}
