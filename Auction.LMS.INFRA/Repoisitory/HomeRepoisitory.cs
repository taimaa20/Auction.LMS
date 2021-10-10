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
    public class HomeRepoisitory : IHomeRepoisitory
    {
        private IDBContext dBContext;


        public HomeRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }
        public bool DeleteHome(int id)
        {
            var p = new DynamicParameters();
            p.Add("@id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteHome", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Home> GetAllHome()
        {
            IEnumerable<Home> result = dBContext.Connection.Query<Home>("GetAllHome", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Home GetHomeById(int id)
        {
            var par = new DynamicParameters();
            par.Add("@id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Home>("GetHomeById", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertHome(Home home)
        {
            
            var parameters = new DynamicParameters();
            parameters.Add("@Title", home.Title, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Story", home.Story, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Phone", home.Phone, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Email", home.Email, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Address", home.Address, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertHome", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateHome(Home home)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", home.Id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Title", home.Title, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Story", home.Story, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Phone", home.Phone, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Email", home.Email, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Address", home.Address, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateHome", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
