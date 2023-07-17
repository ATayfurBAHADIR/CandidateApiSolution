using Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utility
{
    public class Hash
    {
        public string PaymentHash(PaymentRequest request)
        {
            var hashString = $"{request.ApiKey}{request.UserCode}{request.Rnd}{request.TxnType}{request.TotalAmount}{request.CustomerId}{request.OrderId}";
            System.Security.Cryptography.SHA512 s512 = System.Security.Cryptography.SHA512.Create();
            System.Text.UnicodeEncoding ByteConverter = new System.Text.UnicodeEncoding();
            byte[] bytes = s512.ComputeHash(ByteConverter.GetBytes(hashString));
            var hash = System.BitConverter.ToString(bytes).Replace("-", "");
            return hash;
        }
    }
}
