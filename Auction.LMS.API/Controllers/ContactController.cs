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
    public class ContactController : Controller
    {
        private readonly IContactService contactService;
        public ContactController(IContactService _contactService)
        {
            contactService = _contactService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Contact>), StatusCodes.Status200OK)]
        public List<Contact> GetAllContact()
        {
            return contactService.GetAllContact();
        }
        [HttpPost]
        public bool InsertContact([FromBody] Contact contact)
        {
            return contactService.InsertContact(contact);
        }
        [HttpPut]
        public bool UpdateContact(Contact contact)
        {
            return contactService.UpdateContact(contact);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteContact(int id)
        {
            return contactService.DeleteContact(id);
        }
        [HttpGet]
        [Route("getcontactbyid/{id}")]
        public Contact GetAllContactId(int id)
        {
            return contactService.GetAllContactId(id);
        }

    }
}
