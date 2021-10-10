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
    public class SalaryRepoisitory : ISalaryRepoisitory
    {

        private IDBContext dBContext;


        public SalaryRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }
        public bool DeleteSalary(int id)
        {
            var p = new DynamicParameters();
            p.Add("@SalaryId", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteSalary", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Salary> GetAllSalaries()
        {
            IEnumerable<Salary> result = dBContext.Connection.Query<Salary>("GetAllSalaries", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Salary GetSalaryById(int id)
        {
            var par = new DynamicParameters();
            par.Add("@SalaryId", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Salary>("GetSalaryById", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertSalary(Salary salary)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Salary", salary.salary, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Tracks", salary.Tracks, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add(" @Incentives", salary.Incentives, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@EmployeeId", salary.EmployeeId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@MonthOfSalary", salary.MonthOfSalary, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertSalary", parameters, commandType: CommandType.StoredProcedure);
            return true; 
        }

        public bool UpdateSalary(Salary salary)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@SalaryId", salary.SalaryId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Salary", salary.salary, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Tracks", salary.Tracks, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add(" @Incentives", salary.Incentives, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@EmployeeId", salary.EmployeeId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@MonthOfSalary", salary.MonthOfSalary, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateSalary", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
