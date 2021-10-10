
using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
    public interface IAuctionRepository
    {
        public List<Auction1> GetAllAuction();
        public bool InsertAuction(Auction1 auction);
        public bool UpdateAuction(Auction1 auction);
        public bool DeleteAuction(int id);
    }
}
