using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepoisitory messageRepoisitory ;
        public MessageService(IMessageRepoisitory messageRepoisitory)
        {
            this.messageRepoisitory = messageRepoisitory;
        }
        public bool DeleteMessage(int id)
        {
            return messageRepoisitory.DeleteMessage(id);
        }

        public List<Message> GetAllMessages()
        {
            return messageRepoisitory.GetAllMessages();
        }

        public Message GetAllMessagesById(int id)
        {
            return messageRepoisitory.GetAllMessagesById(id);
        }

        public bool InsertMessage(Message message)
        {
            return messageRepoisitory.InsertMessage(message);
        }

        public bool UpdateMessage(Message message)
        {
            return messageRepoisitory.UpdateMessage(message);
        }
    }
}
