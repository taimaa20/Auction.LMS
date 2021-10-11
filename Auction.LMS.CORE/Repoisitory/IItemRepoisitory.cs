using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
   public interface IItemRepoisitory
    {
        public List<Item> GetAllItem();

        public bool InsertItem(Item item );
        public bool UpdateItem(Item item );
        public bool DeleteItem(int id);
        public Item GetItemById(int id);
        public List<Item> SearchByItemName(Item item);
    }
}
