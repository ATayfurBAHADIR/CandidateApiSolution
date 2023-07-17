using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public  class Transaction
    {
        public Guid TransactionId { get; set; }

        public Guid CustomerId { get; set; }
        public Guid OrderId { get; set; }
        public Guid TypeId { get; set; }
        public decimal Amount { get; set; }
        public string CardPan { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public TransactionStatu Status { get; set; }
    }
}
