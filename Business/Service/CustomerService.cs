using AutoMapper;
using Business.ConnectedService;
using Business.Dto;
using Business.Interface;
using Data.Entity;
using Data.Repository.Interface;
using Data.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class CustomerService : ICustomerService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public void AddCustomer(CustomerRequest request)
        {
            Customer customer = _mapper.Map<Customer>(request);
            CheckCustomerIdentityNo(customer);
            _unitOfWork._customer.Add(customer);
            _unitOfWork.Save();

        }
        private bool CheckCustomerIdentityNo(Customer customer)
        {
            var checkService = new CheckIdentityNoService();
            var result = checkService.CheckCustomerIdentityIsValid(customer);
            customer.IdentityNoVerified = result;
            customer.Status = result ? Data.Enum.CustomerStatu.Active : Data.Enum.CustomerStatu.Passive;
            return result;
        }
    }
}
