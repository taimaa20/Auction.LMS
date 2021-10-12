using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
   public interface IContactService
    {
        List<Contact> GetAllContact();
        bool InsertContact(Contact contact);
        bool UpdateContact(Contact contact);
        bool DeleteContact(int id);
        public Contact GetAllContactId(int id);
    }
}
