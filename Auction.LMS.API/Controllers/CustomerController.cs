using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.LMS.API.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService _customerService)
        {
            customerService = _customerService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        public List<Customer> GetAllCustomer()
        {
            return customerService.GetAllCustomer();
        }
        [HttpPost]
        public bool InsertCustomer([FromBody] Customer customer)
        {
            return customerService.InsertCustomer(customer);
        }
        [HttpPut]
        public bool UpdateCustomer(Customer customer)
        {
            return customerService.UpdateCustomer(customer);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteCustomer(int id)
        {
            return customerService.DeleteCustomer(id);
        }
        [HttpGet]
        [Route("getcustomerbyid/{id}")]
        public Customer GetAllCustomerId(int id)
        {
            return customerService.GetAllCustomerId(id);
        }
        [HttpGet]
        [Route("customeritemSaller/{id}")]
        public IEnumerable<CustomerItemSallerDTO> customerItemSallerDTOs(int id)
        {
            return customerService.customerItemSallerDTOs(id);

        }
        [HttpGet]
        [Route("customeritembuyer/{id}")]
        public IEnumerable<CustomerItemBuyerDTO> customerItemBuyerDTOs(int id)
        {
            return customerService.customerItemBuyerDTOs(id);

        }
        [HttpGet]
        [Route("customercount")]

        public IEnumerable<CustomerCountDTO> customerCount()
        {
            return customerService.customerCount();
        }

    }
}