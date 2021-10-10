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
   public class LoginRepoisitory : ILoginRepoisitory
    {
        private IDBContext dBContext;


        public LoginRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;

        }

        

       

        public bool DeleteLogin(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteLogin", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        

        public List<Login> GetAllLogin()
        {
            IEnumerable<Login> result = dBContext.Connection.Query<Login>("GetAllLogin", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Login GetLoginById(int id)
        {
            var par = new DynamicParameters();
            par.Add("@Id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Login>("GetLoginById", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        

        public bool InsertLogin(Login login)
        {

            var parameters = new DynamicParameters();
            parameters.Add("@Username", login.Username, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Password", login.Password, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@DeptId", login.DeptId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@CustomerId", login.CustomerId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@EmployeeId", login.EmployeeId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertLogin", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        
        public bool UpdateLogin(Login login)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", login.Id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Username", login.Username, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Password", login.Password, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@DeptId", login.DeptId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@CustomerId", login.CustomerId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@EmployeeId", login.EmployeeId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            
            var result = dBContext.Connection.ExecuteAsync("UpdateLogin", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        
    }
}
