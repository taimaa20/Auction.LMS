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
    public class MessageRepoisitory : IMessageRepoisitory
    {
        private IDBContext dBContext;


        public MessageRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }
        public bool DeleteMessage(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteMessage", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Message> GetAllMessages()
        {
            IEnumerable<Message> result = dBContext.Connection.Query<Message>("GetAllMessages", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Message GetAllMessagesById(int id)
        {
            var par = new DynamicParameters();
            par.Add("@Id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Message>("GetAllMessagesById", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertMessage(Message message)
        {
   
            var parameters = new DynamicParameters();
            parameters.Add(" @SendMessage", message.SendMessage, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ReplayMessage", message.ReplayMessage, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@MessageDate", message.ReplayMessage, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@CustomerId", message.CustomerId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@EmployeeId", message.EmployeeId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertMessage", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateMessage(Message message)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", message.Id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add(" @SendMessage", message.SendMessage, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ReplayMessage", message.ReplayMessage, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@MessageDate", message.ReplayMessage, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@CustomerId", message.CustomerId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@EmployeeId", message.EmployeeId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateMessage", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
