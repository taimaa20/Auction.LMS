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
   public class ImagesRepoisitory: IImagesRepoisitory
    {
        private IDBContext dBContext;


        public ImagesRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;

        }

        public bool DeleteImages(int id)
        {
            var p = new DynamicParameters();
            p.Add("@id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteImages", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Images> GetAllImages()
        {
            IEnumerable<Images> result = dBContext.Connection.Query<Images>("GetAllImages", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Images GetImagesById(int id)
        {
            var par = new DynamicParameters();
            par.Add("@id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Images>("GetImagesById", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertImages(Images images)
        {
 
            var parameters = new DynamicParameters();
            parameters.Add("@ImageName", images.ImageName, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ItemId", images.ItemId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertImages", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateImages(Images images)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", images.Id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ImageName", images.ImageName, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ItemId", images.ItemId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateImages", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
