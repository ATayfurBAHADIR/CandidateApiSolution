using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto
{
    public class TransactionResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string TxnStatus { get; set; }
        public string HostReferenceNumber { get; set; }
        public string ExtraData { get; set; }
        public string TransId { get; set; }
        public PaymentResult Result { get; set; }
    }
}
