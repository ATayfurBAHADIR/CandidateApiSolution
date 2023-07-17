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

        public async Task<TransactionResponse> Post(TransactionRequest request)
        {
            using var httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://ppgpayment-test.birlesikodeme.com:20000/");

            var loginService = new LoginService();
            var loginResponse = await loginService.Post();
            httpClient.DefaultRequestHeaders.Authorization =
                                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", loginResponse.result.Token);

            var hash = new Hash().PaymentHash(new PaymentRequest
            {
                ApiKey = request.ApiKey,
                HashPassword = request.Password,
                UserCode = request.UserCode,
                OrderId = request.OrderId,
                CustomerId = request.CustomerId,
                TotalAmount = request.TotalAmount,
                Rnd = request.Rnd,
                TxnType = request.TxnType,
                CardPan = request.CardPan
            });
            request.Hash = hash;
            var serializeProduct = System.Text.Json.JsonSerializer.Serialize(request);

            StringContent stringContent = new StringContent(serializeProduct, Encoding.UTF8, "application/json");

            var resultContent = await httpClient.PostAsync("api/ppg/Payment/NoneSecurePayment", stringContent);
            var contents = await resultContent.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TransactionResponse>(contents);
            return result;

        }
    }
}
