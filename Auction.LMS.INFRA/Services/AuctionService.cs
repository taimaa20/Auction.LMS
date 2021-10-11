using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class AuctionService : IAuctionService
    {
        private readonly IAuctionRepository auctionRepository ;
        public AuctionService(IAuctionRepository auctionRepository)
        {
            this.auctionRepository = auctionRepository;
        }
        public List<AuctionInSpecificIntervalDTO> AuctionInSpecificInterval(AuctionInSpecificIntervalDTO auction)
        {
            return auctionRepository.AuctionInSpecificInterval(auction);
        }

        public bool DeleteAuction(int id)
        {
            return auctionRepository.DeleteAuction(id);
        }

        public List<Auction1> GetAllAuction()
        {
            return auctionRepository.GetAllAuction();
        }

        public bool InsertAuction(Auction1 auction)
        {
            return auctionRepository.InsertAuction(auction);
        }

        public List<Auction1> RemainingTime(Auction1 auction)
        {
            return auctionRepository.RemainingTime(auction);
        }

        public bool UpdateAntiquesStatus(Auction1 auction)
        {
            return auctionRepository.UpdateAntiquesStatus(auction);
        }

        public bool UpdateAuction(Auction1 auction)
        {
            return auctionRepository.UpdateAuction(auction);
        }

        public bool UpdateBidPriceAuction(Auction1 auction)
        {
            return auctionRepository.UpdateBidPriceAuction(auction);
        }
    }
}
