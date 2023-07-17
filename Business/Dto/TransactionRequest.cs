using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto
{
    public class TransactionRequest
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string Lang { get; set; }
        public string ApiKey { get; set; }
        public string ExpiryDateMonth { get; set; }
        public string ExpiryDateYear { get; set; }
        public string Amount { get; set; }
        public string TotalAmount { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string CommissionRate { get; set; }
        public string Currency { get; set; }
        public string InstallmentCount { get; set; }
        public string TxnType { get; set; }
        public string Rnd { get; set; }
        public int CustomerId { get; set; }
        public int MerchantId { get; set; }
        public int MemberId { get; set; }
        public string Hash { get; set; }
        public string UserCode { get; set; }
        public string OrderId { get; set; }
        public string CardPan { get; set; }
        public string CVV { get; set; }
    }
}
