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
    public class AuctionRepository : IAuctionRepository
    {
        private readonly IDBContext DbContext;
        public AuctionRepository(IDBContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public List<Auction1> GetAllAuction()
        {
            IEnumerable<Auction1> result = DbContext.Connection.Query<Auction1>("GetAllAuction", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool InsertAuction(Auction1 auction)
        {
            var p = new DynamicParameters();
            p.Add("@StartDate", auction.StartDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@EndDate", auction.EndDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@Bidprice", auction.Bidprice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@Commetion", auction.Commetion, dbType: DbType.Double, direction: ParameterDirection.Input);

            p.Add("@InitialPrice", auction.InitialPrice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@MarketEstimated", auction.Bidprice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@Status", auction.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@EmployeeId", auction.EmployeeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ItemId", auction.ItemId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CustomerId", auction.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("InsertAuction", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateAuction(Auction1 auction)
        {
            var p = new DynamicParameters();
            p.Add("@Id", auction.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@StartDate", auction.StartDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@EndDate", auction.EndDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@Bidprice", auction.Bidprice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@Commetion", auction.Commetion, dbType: DbType.Double, direction: ParameterDirection.Input);

            p.Add("@InitialPrice", auction.InitialPrice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@MarketEstimated", auction.Bidprice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@Status", auction.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@EmployeeId", auction.EmployeeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ItemId", auction.ItemId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CustomerId", auction.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("UpdateAuction", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteAuction(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("DeleteAuction", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateBidPriceAuction(Auction1 auction)
        {
               var p = new DynamicParameters();
            p.Add("@Id", auction.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Bidprice", auction.Bidprice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@CustomerId", auction.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("UpdateBidPriceAuction", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateAntiquesStatus(Auction1 auction)
        {
            var p = new DynamicParameters();
            p.Add("@Id", auction.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Status", auction.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("UpdateAntiquesStatus", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Auction1> RemainingTime(Auction1 auction)
        {
            var p = new DynamicParameters();
            p.Add("@Id", auction.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Auction1> result = DbContext.Connection.Query<Auction1>("RemainingTime", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<AuctionInSpecificIntervalDTO> AuctionInSpecificInterval(AuctionInSpecificIntervalDTO auction)
        {
            var p = new DynamicParameters();
            p.Add("@StartDate", auction.Fromdate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@EndDate", auction.Todate, dbType: DbType.Date, direction: ParameterDirection.Input);
            IEnumerable<AuctionInSpecificIntervalDTO> result = DbContext.Connection.Query<AuctionInSpecificIntervalDTO>("AuctionInSpecificInterval", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public IEnumerable<MaxBidPriceDTO> customerCount()
        {
          

                IEnumerable<MaxBidPriceDTO> result = DbContext.Connection.Query<MaxBidPriceDTO>("MaxBidPrice", commandType: CommandType.StoredProcedure);
                return result.ToList();

            
        }
    }
}
