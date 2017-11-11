using System;
using System.Net.Http;
using Newtonsoft.Json;
using service.contract;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                var rawCustomer = client.GetStringAsync("http://localhost:5000/api/Customers/1").Result;

                Console.WriteLine(rawCustomer);

                var customer = JsonConvert.DeserializeObject<Customer>(rawCustomer);

                Console.WriteLine($"Imię: {customer.FirstName}. Nazwisko: {customer.LastName}");
            }
        }
    }
}
