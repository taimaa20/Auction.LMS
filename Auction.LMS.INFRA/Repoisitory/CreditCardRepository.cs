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
   public class CreditCardRepository: ICreditCardRepository
    {
        private readonly IDBContext DbContext;
        public CreditCardRepository(IDBContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public List<CreditCard> GetAllCreditCard()
        {
            IEnumerable<CreditCard> result = DbContext.Connection.Query<CreditCard>("GetAllCreditCard", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool InsertCreditCard(CreditCard creditCard)
        {
            var p = new DynamicParameters();
            p.Add("@Name", creditCard.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IssueDate", creditCard.IssueDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@ExpiryDate", creditCard.ExpiryDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@CustomerId", creditCard.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@Balance", creditCard.Balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@PaymentId", creditCard.PaymentId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            
            var result = DbContext.Connection.ExecuteAsync("InsertCreditCard", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateCreditCard(CreditCard creditCard)
        {
            var p = new DynamicParameters();
            p.Add("@Id", creditCard.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", creditCard.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IssueDate", creditCard.IssueDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@ExpiryDate", creditCard.ExpiryDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@CustomerId", creditCard.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@Balance", creditCard.Balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@PaymentId", creditCard.PaymentId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("UpdateCreditCard", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteCreditCard(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("DeleteCreditCard", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public CreditCard GetAllCreditCardId(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = DbContext.Connection.Query<CreditCard>("GetByIdCreditCard", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

    }
}
