using Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Business.ConnectedService
{
    public class LoginService
    {
        public async Task<LoginResponse> Post()
        {
            using var httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://ppgsecurity-test.birlesikodeme.com:55002/");

            LoginRequest request = new LoginRequest()
            {

                ApiKey = "kU8@iP3@",
                Email = "murat.karayilan@dotto.com.tr",
                Lang = "TR"
            };

            var serializeProduct = System.Text.Json.JsonSerializer.Serialize(request);

            StringContent stringContent = new StringContent(serializeProduct, Encoding.UTF8, "application/json");

            var result = await httpClient.PostAsync("api/ppg/Securities/authenticationMerchant", stringContent);
            var contents =await result.Content.ReadAsStringAsync();
            var result1 = JsonConvert.DeserializeObject<LoginResponse>(contents);

            
            return result1;

        }


    }
}
