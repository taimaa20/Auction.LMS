using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepoisitory itemRepoisitory;
        public ItemService(IItemRepoisitory itemRepoisitory)
        {
            this.itemRepoisitory = itemRepoisitory;
        }
        public bool DeleteItem(int id)
        {
            return itemRepoisitory.DeleteItem(id);
        }

        public List<Item> GetAllItem()
        {
            return itemRepoisitory.GetAllItem();
        }

        public Item GetItemById(int id)
        {
            return itemRepoisitory.GetItemById(id);
        }

        public bool InsertItem(Item item)
        {
            return itemRepoisitory.InsertItem(item);
        }

        public List<ItemDTO> OfferItemPrice(ItemDTO itemDTO)
        {
            return itemRepoisitory.OfferItemPrice(itemDTO);
        }

        public List<Item> SearchByItemName(Item item)
        {
            return itemRepoisitory.SearchByItemName(item);
        }

        public bool UpdateItem(Item item)
        {
            return itemRepoisitory.UpdateItem(item);
        }
    }
}
