using Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public int MerchantId { get; set; }
        public int MemberId { get; set; }
        public string Amount { get; set; }
        public string CardPan { get; set; }
        public string TxnType { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public TransactionStatu Status { get; set; }
    }
}
