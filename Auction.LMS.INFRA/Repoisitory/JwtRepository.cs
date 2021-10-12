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
 public  class JwtRepository: IJwtRepository
    {
        private readonly IDBContext dBContext;
        public JwtRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public Login Auth(Login login)
        {
            var p = new DynamicParameters();
            p.Add("@UserName", login.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@password", login.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Login> result = dBContext.Connection.Query<Login>("LoginProc", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
