using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
   public interface ICustomerRepository
    {
        public List<Customer> GetAllCustomer();
        public bool DeleteCustomer(int id);
        public bool UpdateCustomer(Customer customer);
        public bool InsertCustomer(Customer customer);




    }
}
