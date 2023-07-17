using AutoMapper;
using Business.ConnectedService;
using Business.Dto;
using Business.Interface;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class TransactionService : ITransactionService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TransactionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public TransactionResponse AddTransaction(TransactionRequest request)
        {
            var paymentService = new PaymentService();
            return paymentService.Post(request).Result;
        }
    }
}
