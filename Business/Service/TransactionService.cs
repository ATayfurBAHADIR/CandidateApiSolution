using AutoMapper;
using Business.ConnectedService;
using Business.Dto;
using Business.Interface;
using Data.Entity;
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
            Transaction transaction = _mapper.Map<Transaction>(request);
            _unitOfWork._transaction.Add(transaction);
            _unitOfWork.Save();
            var response = paymentService.Post(request).Result;
            transaction.ResponseCode = response.Result.ResponseCode;
            transaction.ResponseMessage = response.Result.ResponseMessage;
            _unitOfWork._transaction.Update(transaction);
            _unitOfWork.Save();
            return response;
        }
    }
}
