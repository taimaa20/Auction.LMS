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
    public class TestmonialRepoisitory : ITestmonialRepoisitory
    {
        private IDBContext dBContext;


        public TestmonialRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }
        public bool DeleteTestmonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteTestmonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Testmonial> GetAllTestmonials()
        {
            IEnumerable<Testmonial> result = dBContext.Connection.Query<Testmonial>("GetAllTestmonials", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Testmonial GetTestemonialById(int id)
        {
            var par = new DynamicParameters();
            par.Add("@Id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Testmonial>("GetTestemonialById", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertTestemonial(Testmonial testmonial)
        {

            var parameters = new DynamicParameters();
            parameters.Add("@Name", testmonial.Name, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Comments", testmonial.Comments, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ImageName", testmonial.ImageName, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Status", testmonial.Status, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertTestemonial", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateTestmonial(Testmonial testmonial)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", testmonial.Id, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            parameters.Add("@Name", testmonial.Name, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Comments", testmonial.Comments, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ImageName", testmonial.ImageName, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Status", testmonial.Status, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateTestmonial", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
