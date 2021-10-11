using Auction.LMS.CORE.Common;
using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Repoisitory;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Auction.LMS.INFRA.Repoisitory
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly IDBContext DbContext;
        public CustomerRepository(IDBContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool InsertCustomer(Customer customer)
        {
            var p = new DynamicParameters();
            p.Add("@Fname", customer.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Lname", customer.Lname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", customer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", customer.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Country", customer.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", customer.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ImageName", customer.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MyProperty", customer.MyProperty, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("InsertCustomer", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateCustomer(Customer customer)
        {
            var p = new DynamicParameters();
            p.Add("@Id", customer.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Fname", customer.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Lname", customer.Lname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", customer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", customer.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Country", customer.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", customer.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ImageName", customer.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MyProperty", customer.MyProperty, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("UpdateCustomer", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteCustomer(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("DeleteCustomer", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Customer> GetAllCustomer()
        {
            IEnumerable<Customer> result = DbContext.Connection.Query<Customer>("GetAllCustomer", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

      
     

        public IEnumerable<CustomerCountDTO> customerCount()
        {
            
                IEnumerable<CustomerCountDTO> result = DbContext.Connection.Query<CustomerCountDTO>("NumberOfCustomer", commandType: CommandType.StoredProcedure);
                return result.ToList();
           
        }
    
        public IEnumerable<CustomerItemSallerDTO> customerItemSallerDTOs(int id)
        {
            var par = new DynamicParameters();
            par.Add("@CustomerId", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            IEnumerable<CustomerItemSallerDTO> result = DbContext.Connection.Query<CustomerItemSallerDTO>("CustomerItemSaller", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public IEnumerable<CustomerItemBuyerDTO> customerItemBuyerDTOs(int id)
        {
            var par = new DynamicParameters();
            par.Add("@CustomerId", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            IEnumerable<CustomerItemBuyerDTO> result = DbContext.Connection.Query<CustomerItemBuyerDTO>("CustomerItemBuyer", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
    }
}
