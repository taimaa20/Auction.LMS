using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
   public class ContactService: IContactService
    {
        private readonly IContactRepository contactRepository ;
        public ContactService(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public bool DeleteContact(int id)
        {
            return contactRepository.DeleteContact(id);
        }

        public List<Contact> GetAllContact()
        {
            return contactRepository.GetAllContact();
        }

        public bool InsertContact(Contact contact)
        {
            return contactRepository.InsertContact(contact);
        }

        public bool UpdateContact(Contact contact)
        {
            return contactRepository.UpdateContact(contact);
        }
    }
}
