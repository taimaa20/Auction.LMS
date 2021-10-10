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
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly IDBContext DbContext;
        public EmployeeRepository(IDBContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public List<Employee> GetAllEmployee()
        {
            IEnumerable<Employee> result = DbContext.Connection.Query<Employee>("GetAllEmployee", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool InsertEmployee(Employee employee)
        {
            var p = new DynamicParameters();
            p.Add("@Name", employee.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", employee.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", employee.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DeptId", employee.DeptId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Gender", employee.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@BirthDate", employee.BirthDate, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ImageName", employee.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("InsertEmployee", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateEmployee(Employee employee)
        {
            var p = new DynamicParameters();
            p.Add("@Id", employee.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", employee.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", employee.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", employee.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DeptId", employee.DeptId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Gender", employee.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@BirthDate", employee.BirthDate, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ImageName", employee.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("UpdateEmployee", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteEmployee(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("DeleteEmployee", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
