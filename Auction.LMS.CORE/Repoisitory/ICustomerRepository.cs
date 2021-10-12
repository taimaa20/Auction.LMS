using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
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

 
        public IEnumerable<CustomerItemSallerDTO> customerItemSallerDTOs(int id);

        public IEnumerable<CustomerItemBuyerDTO> customerItemBuyerDTOs(int id);
   
        public IEnumerable<CustomerCountDTO> customerCount();
        public Customer GetAllCustomerId(int id);

    }
}
