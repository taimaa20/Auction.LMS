using Auction.LMS.CORE.Common;
using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Repoisitory;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Auction.LMS.INFRA.Repoisitory
{
    public class RegisterRepository : IRegisterRepository
    {
        private readonly IDBContext DbContext;
        public RegisterRepository(IDBContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool InsertRegister(RegistorDTO registorDTO)
        {
            var p = new DynamicParameters();
            p.Add("@Fname", registorDTO.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Lname", registorDTO.Lname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", registorDTO.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", registorDTO.Phone, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@Country", registorDTO.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", registorDTO.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Street", registorDTO.Street, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ImageName", registorDTO.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Username", registorDTO.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@@Password", registorDTO.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DeptId", registorDTO.DeptId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CustomerId", registorDTO.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@EmployeeId", registorDTO.EmployeeId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("RegisterCustomer", p, commandType: CommandType.StoredProcedure);
            return true;

        }
    }
}
