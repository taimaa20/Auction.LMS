using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class CreditCardService : ICreditCardService
    {
        private readonly ICreditCardRepository creditCardRepository ;
        public CreditCardService(ICreditCardRepository creditCardRepository)
        {
            this.creditCardRepository = creditCardRepository;
        }
        public bool DeleteCreditCard(int id)
        {
            return creditCardRepository.DeleteCreditCard(id);
        }

        public List<CreditCard> GetAllCreditCard()
        {
            return creditCardRepository.GetAllCreditCard();
        }

        public bool InsertCreditCard(CreditCard creditCard)
        {
            return creditCardRepository.InsertCreditCard(creditCard);
        }

        public bool UpdateCreditCard(CreditCard creditCard)
        {
            return creditCardRepository.UpdateCreditCard(creditCard);
        }
    }
}
