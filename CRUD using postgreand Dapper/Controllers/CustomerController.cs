using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using CRUD_using_postgreand_Dapper.Models;
using CRUD_using_postgreand_Dapper.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CRUD_using_postgreand_Dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepository customerRepository;
        public CustomerController(IConfiguration configuration)
        {
            customerRepository = new CustomerRepository(configuration);
        }
        public IEnumerable<Customer> Get()
        {
            return customerRepository.FindAll();
        }
    }
}