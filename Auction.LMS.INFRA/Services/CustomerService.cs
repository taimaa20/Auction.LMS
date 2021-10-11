using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public bool DeleteCustomer(int id)
        {
            return customerRepository.DeleteCustomer(id);
        }

        public List<Customer> GetAllCustomer()
        {
            return customerRepository.GetAllCustomer();
        }

        public bool InsertCustomer(Customer customer)
        {
            return customerRepository.InsertCustomer(customer);
        }

        public bool UpdateCustomer(Customer customer)
        {
            return customerRepository.UpdateCustomer(customer);
        }
    }
}
