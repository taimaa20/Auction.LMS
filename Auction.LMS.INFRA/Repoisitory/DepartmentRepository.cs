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
    public class DepartmentRepository : IDepartmentRepository
    {
       
            private readonly IDBContext DbContext;
            public DepartmentRepository(IDBContext _DbContext)
            {
                DbContext = _DbContext;
            }
            public List<Department> GetAllDepartment()
            {
                IEnumerable<Department> result = DbContext.Connection.Query<Department>("GetAllDepartment", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
            public bool InsertDepartment(Department department)
            {
                var p = new DynamicParameters();
                p.Add("@Name", department.Name, dbType: DbType.String, direction: ParameterDirection.Input);
                var result = DbContext.Connection.ExecuteAsync("InsertDepartment", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            public bool UpdateDepartment(Department department)
            {
                var p = new DynamicParameters();
                p.Add("@Id", department.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
                p.Add("@Name", department.Name, dbType: DbType.String, direction: ParameterDirection.Input);
                var result = DbContext.Connection.ExecuteAsync("UpdateDepartment", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            public bool DeleteDepartment(int id)
            {
                var p = new DynamicParameters();
                p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
                var result = DbContext.Connection.ExecuteAsync("DeleteDepartment", p, commandType: CommandType.StoredProcedure);
                return true;
            }

        
    }
}
