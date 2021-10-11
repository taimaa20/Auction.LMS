using Auction.LMS.CORE.Common;
using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Repoisitory;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Auction.LMS.INFRA.Repoisitory
{
   public class ItemRepoisitory: IItemRepoisitory
    {
        private IDBContext dBContext;


        public ItemRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }

        public bool DeleteItem(int id)
        {
            var p = new DynamicParameters();
            p.Add("@id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteItem", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Item> GetAllItem()
        {
            IEnumerable<Item> result = dBContext.Connection.Query<Item>("GetAllItem", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Item GetItemById(int id)
        {
            var par = new DynamicParameters();
            par.Add("@id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Item>("GetItemById", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertItem(Item item)
        {
  
            var parameters = new DynamicParameters();
            parameters.Add("@Description", item.Description, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@PublishDate", item.PublishDate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@CategoryId", item.CategoryId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
           
            var result = dBContext.Connection.ExecuteAsync("InsertItem", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateItem(Item item)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", item.Id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Description", item.Description, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@PublishDate", item.PublishDate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@CategoryId", item.CategoryId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateItem", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Item> SearchByItemName(Item item)
        {

        
            var p = new DynamicParameters();
            p.Add("@ItemName", item.Name, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<Item> result = dBContext.Connection.Query<Item>("SearchByItemName", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public List<ItemDTO> OfferItemPrice(ItemDTO itemDTO)
        {
            var p = new DynamicParameters();
            p.Add("@Id", itemDTO.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CustomerId", itemDTO.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<ItemDTO> result = dBContext.Connection.Query<ItemDTO>("OfferItemPrice", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
