using Business.Dto;
using Business.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ConnectedService
{
    public class PaymentService
    {
        public async Task Post()
        {
            using var httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://ppgpayment-test.birlesikodeme.com:20000/");

            var loginService = new LoginService();
            var loginResponse = await loginService.Post();
            httpClient.DefaultRequestHeaders.Authorization =
                                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", loginResponse.result.Token);
            var apiKey = "SKI0NDHEUP60J7QVCFATP9TJFT2OQFSO";
            var hashPassword = "kU8@iP3@";
            var rnd = "ATB_ATB";
            var totalAmount = "100";
            var txnType = "Auth";
            var userCode = "aydogan.tayfur.bahadir";
            var customerId = 2020;
            var orderId = "1990";
            var cardPan = "4355084355084358";

            var hash = new Hash().PaymentHash(new PaymentRequest
            {
                ApiKey = apiKey,
                HashPassword = hashPassword,
                UserCode = userCode,
                OrderId = orderId,
                CustomerId = customerId,
                TotalAmount = totalAmount,
                Rnd = rnd,
                TxnType = txnType,
                CardPan = cardPan
            }); 
            TransactionRequest request = new TransactionRequest()
            {

                Password = hashPassword,
                Email = "murat.karayilan@dotto.com.tr",
                Lang = "TR",
                ApiKey = apiKey,
                MerchantId = 1894,
                MemberId = 1,
                Hash = hash,
                Rnd = rnd,
                Amount = "100",
                TotalAmount = totalAmount,
                CustomerId = customerId,
                ExpiryDateMonth = "12",
                ExpiryDateYear = "2026",
                ProductId = "202020",
                ProductName = "test",
                CommissionRate = "15.00",
                Currency = "949",
                InstallmentCount = "1",
                TxnType = txnType,
                UserCode = userCode,
                OrderId = orderId,
                CVV = "000",


            };
            //var hashString = $"{apiKey}{request.UserCode}{request.Rnd}{request.TxnType}{request.TotalAmount}
            var serializeProduct = System.Text.Json.JsonSerializer.Serialize(request);

            StringContent stringContent = new StringContent(serializeProduct, Encoding.UTF8, "application/json");

            var result = await httpClient.PostAsync("api/ppg/Payment/NoneSecurePayment", stringContent);
            var contents = await result.Content.ReadAsStringAsync();
            //var result1 = JsonConvert.DeserializeObject<LoginResponse>(contents);


            //return result1;

        }
    }
}
