﻿using System;
using System.Web.Http;

namespace Swagger.Net.Dummy.Controllers
{
    public class CustomersController : ApiController
    {
        public int Create(Customer customer, int adminLevel = 0)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public void Update(int id, Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}