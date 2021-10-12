using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.LMS.API.Controllers
{
    public class AuctionController : Controller
    {
        private readonly IAuctionService auctionService;
        public AuctionController(IAuctionService _auctionService)
        {
            auctionService = _auctionService;
        }
    [HttpGet]
    [ProducesResponseType(typeof(List<Auction1>), StatusCodes.Status200OK)]
    public List<Auction1> GetAllAuction()
    {
        return auctionService.GetAllAuction();
    }
    [HttpPost]
    public bool InsertAuction([FromBody] Auction1 auction)
    {
        return auctionService.InsertAuction(auction);
    }
    [HttpPut]
    public bool UpdateAuction(Auction1 auction)
    {
        return auctionService.UpdateAuction(auction);
    }
    [HttpDelete("delete/{id}")]
    public bool DeleteAuction(int Auctionid)
    {
        return auctionService.DeleteAuction(Auctionid);
    }
    [HttpGet]
    [Route("getAuctionbyid/{id}")]
    public Auction1 GetAllAuctionId(int id)
    {
            return auctionService.GetAllAuctionId(id);
    }
    [HttpPut]
    public bool UpdateBidPriceAuction(Auction1 auction)
    {
        return auctionService.UpdateBidPriceAuction(auction);
    }
    [HttpPut]
    public bool UpdateAntiquesStatus(Auction1 auction)
    {
        return auctionService.UpdateAntiquesStatus(auction);
    }
    [HttpGet]
    [ProducesResponseType(typeof(List<Auction1>), StatusCodes.Status200OK)]
    public List<Auction1> RemainingTime(Auction1 auction)
    {
        return auctionService.RemainingTime(auction);
    }
    [HttpGet]
    [ProducesResponseType(typeof(List<Auction1>), StatusCodes.Status200OK)]
    public List<AuctionInSpecificIntervalDTO> AuctionInSpecificInterval(AuctionInSpecificIntervalDTO auction)
    {
        return auctionService.AuctionInSpecificInterval(auction);
    }
    [HttpGet]
    [ProducesResponseType(typeof(List<Auction1>), StatusCodes.Status200OK)]
    public IEnumerable<MaxBidPriceDTO> MaxBid()
    {
        return auctionService.MaxBid();
    }
}
}
