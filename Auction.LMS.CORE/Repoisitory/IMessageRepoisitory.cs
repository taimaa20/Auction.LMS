using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
   public interface IMessageRepoisitory
    {
        public List<Message> GetAllMessages();

        public bool InsertMessage(Message message );
        public bool UpdateMessage(Message message );
        public bool DeleteMessage(int id);
        public Message GetAllMessagesById(int id);
    }
}
