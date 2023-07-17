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
            var hashString = $"{request.ApiKey}{request.HashPassword}{request.UserCode}{request.Rnd}{request.TxnType}{request.TotalAmount}{request.CustomerId}{request.OrderId}{request.OkUrl}{request.FailUrl}";
            var s512 = SHA512.Create(); 
            var byteConverter = new UnicodeEncoding(); 
            var bytes = s512.ComputeHash(byteConverter.GetBytes(hashString)); 
            var hash = BitConverter.ToString(bytes).Replace("-", ""); 
            return hash;
        }
    }
}
