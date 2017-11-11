using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using service.contract;

namespace service.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private static Customer[] _customers = new[] {
                new Customer{
                    Id = 1,
                    LastName="Kowalski",
                    DateOfBirth = new DateTime(1990,1,1)},
            new Customer{
                Id = 2,
                 LastName="Nowak",DateOfBirth = new DateTime(1980,1,1)} };

        // GET api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        // POST api/values
        // [HttpPost]
        // public void Post([FromBody]string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
