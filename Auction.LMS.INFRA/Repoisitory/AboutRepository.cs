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
    public class AboutRepository : IAboutRepository
    {
        private readonly IDBContext DbContext;
        public AboutRepository(IDBContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public List<About> GetAllAbout()
        {
            IEnumerable<About> result =
            DbContext.Connection.Query<About>("GetAllAbout", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool InsertAbout(About about)
        {
            var p = new DynamicParameters();
            p.Add("@Name", about.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ImageName", about.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Story", about.Story, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("InsertAbout", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateAbout(About about)
        {
            var p = new DynamicParameters();
            p.Add("@Id", about.Id, dbType: DbType.Int32,direction: ParameterDirection.Input);
            p.Add("@Name", about.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ImageName", about.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Story", about.Story, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("UpdateAbout",p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteAbout(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction:ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("DeleteAbout",p, commandType: CommandType.StoredProcedure);
            return true;
        }


    }
    }
