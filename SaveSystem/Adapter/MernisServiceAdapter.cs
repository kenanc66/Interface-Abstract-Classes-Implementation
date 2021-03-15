
using MernisServiceReference;
using SaveSystem.Abstract;
using SaveSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, 
                customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
