using Auction.LMS.CORE.Data;
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
    public class MessageController : ControllerBase
    {
        private readonly IMessageService messageService ;
        public MessageController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        [HttpGet]
        public List<Message> GetAllMessages()
        {
            return messageService.GetAllMessages();
        }

        [HttpPost]
        public bool InsertMessage([FromBody]Message message)
        {
            return messageService.InsertMessage(message);
        }

       [HttpPut]
        public bool UpdateMessage(Message message)
        {
            return messageService.UpdateMessage(message);
        }

        [HttpDelete("delete/{id}")]
        public bool DeleteMessage(int id)
        {
            return messageService.DeleteMessage(id);
        }
        [HttpGet]
        [Route("getmessagebyid/{id}")]
        public Message GetAllMessagesById(int id)
        {
            return messageService.GetAllMessagesById(id);
        }
    }
}
