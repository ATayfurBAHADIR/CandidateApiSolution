using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entity;
using KPSService;

namespace Business.ConnectedService
{
    public class CheckIdentityNoService
    {
        public bool CheckCustomerIdentityIsValid(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return  client.TCKimlikNoDogrulaAsync(
                Convert.ToInt64(customer.IdentityNo),
                customer.Name,
                customer.Surname,
                customer.BirthDate.Year
               
            ).Result.Body.TCKimlikNoDogrulaResult;
        }


    }

}
