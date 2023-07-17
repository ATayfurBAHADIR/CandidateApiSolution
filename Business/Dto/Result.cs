using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto
{
    public class PaymentResult
    {
        public string Url { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string BankResponseMessage { get; set; }
        public string OrderId { get; set; }
        public string BankOrderNo { get; set; }
        public string TxnType { get; set; }
        public string TxnStatus { get; set; }
        public int? VposId { get; set; }
        public string VposName { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public string TotalAmount { get; set; }
        public bool? HideResponseTarget { get; set; }
        public string SaleDate { get; set; }
        public string PaymentSystem { get; set; }
        public string ResponseHash { get; set; }
        public string InstallmentCount { get; set; }
    }
}
