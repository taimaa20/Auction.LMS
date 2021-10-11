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
    public class PaymentRepoisitory : IPaymentRepoisitory
    {
        private IDBContext dBContext;


        public PaymentRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }
        public bool DeletePayment(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeletePayment", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public EmployeeCustomerPaymentInformationDTO EmployeeCustomerPaymentInformationDTO(int id)
        {
            var par = new DynamicParameters();
            par.Add("@Id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<EmployeeCustomerPaymentInformationDTO>("EmployeeCustomerPaymentInformation", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public List<Payment> GetAllPayments()
        {
            IEnumerable<Payment> result = dBContext.Connection.Query<Payment>("GetAllPayments", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Payment GetAllPaymentsById(int id)
        {
            var par = new DynamicParameters();
            par.Add("@Id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Payment>("GetAllPaymentsById", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Payment GetPaymentByCustomerId(int id)
        {
            var par = new DynamicParameters();
            par.Add("@CustomerId", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Payment>("GetPaymentByCustomerId", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertPayment(Payment payment)
        {
   
            var parameters = new DynamicParameters();
            parameters.Add("@PaymentDate", payment.PaymentDate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@PaymentAmount", payment.PaymentAmount, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@CustomerId", payment.CustomerId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@EmployeeId", payment.EmployeeId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ItemId", payment.ItemId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertPayment", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdatePayment(Payment payment)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id",payment.Id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@PaymentDate", payment.PaymentDate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@PaymentAmount", payment.PaymentAmount, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@CustomerId", payment.CustomerId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@EmployeeId", payment.EmployeeId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ItemId", payment.ItemId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdatePayment", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
