using Auction.LMS.CORE.Common;
using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Auction.LMS.INFRA.Repoisitory
{
    public class ContactRepository: IContactRepository
    {
        private readonly IDBContext DbContext;
        public ContactRepository(IDBContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public List<Contact> GetAllContact()
        {
            IEnumerable<Contact> result = DbContext.Connection.Query<Contact>("GetAllContact", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool InsertContact(Contact contact)
        {
            var p = new DynamicParameters();
            p.Add("@Name", contact.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", contact.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Subject", contact.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Message", contact.Message, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@Phone", contact.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
           
            var result = DbContext.Connection.ExecuteAsync("InsertContact", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateContact(Contact contact)
        {
            var p = new DynamicParameters();
            p.Add("@Id", contact.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", contact.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", contact.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Subject", contact.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Message", contact.Message, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@Phone", contact.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("UpdateContact", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteContact(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("DeleteContact", p, commandType: CommandType.StoredProcedure);
            return true;
        }

    }
}
