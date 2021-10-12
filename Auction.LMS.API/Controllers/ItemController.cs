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
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService itemService;
        public ItemController(IItemService itemService)
        {
            this.itemService = itemService;
        }

        [HttpGet]
        public List<Item> GetAllItem()
        {
            return itemService.GetAllItem();
        }

        [HttpPost]
        public bool InsertItem([FromBody]Item item)
        {
            return itemService.InsertItem(item);
        }

        [HttpPut]
        public bool UpdateItem(Item item)
        {
            return itemService.UpdateItem(item);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteItem(int id)
        {
            return itemService.DeleteItem(id);
        }
        [HttpGet]
        [Route("getitembyid/{id}")]
        public Item GetItemById(int id)
        {
            return itemService.GetItemById(id);
        }
        [HttpPost]
        [Route("SearchByItemName")]
        public List<Item> SearchByItemName([FromBody]Item item)
        {
            return itemService.SearchByItemName(item);
        }
        [HttpPost]
        [Route("OfferItemPrice")]
        public List<ItemDTO> OfferItemPrice([FromBody]ItemDTO itemDTO)
        {
            return itemService.OfferItemPrice(itemDTO);
        }
        [HttpGet]
        [Route("CountEmployee")]
        public IEnumerable<EmployeeCountDTO> CountEmployee()
        {
            return itemService.CountEmployee();
        }
    }
}
