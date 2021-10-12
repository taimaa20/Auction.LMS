using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
   public interface IContactRepository
    {
        List<Contact> GetAllContact();
        bool InsertContact(Contact contact);
        bool UpdateContact(Contact contact);
        bool DeleteContact(int id);
        public Contact GetAllContactId(int id);
    }
}
