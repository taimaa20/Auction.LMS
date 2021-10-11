using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
   public interface IMessageService
    {
        public List<Message> GetAllMessages();

        public bool InsertMessage(Message message);
        public bool UpdateMessage(Message message);
        public bool DeleteMessage(int id);
        public Message GetAllMessagesById(int id);
    }
}
