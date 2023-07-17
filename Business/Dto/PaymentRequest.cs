using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto
{
    public class PaymentRequest
    {
        public int CustomerId { get; set; }
        public string OrderId { get; set; }
        public string CardPan { get; set; }
        public string ApiKey { get; set; }
        public string HashPassword { get; set; }
        public string UserCode { get; set; }
        public string Rnd { get; set; }
        public string TxnType { get; set; }
        public string TotalAmount { get; set; }
    }
}
