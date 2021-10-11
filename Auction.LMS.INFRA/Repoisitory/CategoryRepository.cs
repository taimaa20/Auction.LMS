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
   public class CategoryRepository: ICategoryRepository
    {
        private readonly IDBContext DbContext;
        public CategoryRepository(IDBContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public List<Category> GetAllCategory()
        {
            IEnumerable<Category> result =DbContext.Connection.Query<Category>("GetAllCategory", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool InsertCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("@Name", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);
             var result = DbContext.Connection.ExecuteAsync("InsertAbout", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("@Id", category.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("UpdateCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("DeleteCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Category> SearchByCategoryName(Category category)
        {
            var p = new DynamicParameters();
            p.Add("@Name", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Category> result = DbContext.Connection.Query<Category>("SearchByCategoryName", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
