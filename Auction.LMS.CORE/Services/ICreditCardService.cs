using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
   public interface ICreditCardService
    {
        List<CreditCard> GetAllCreditCard();
        bool InsertCreditCard(CreditCard creditCard);
        bool UpdateCreditCard(CreditCard creditCard);
        bool DeleteCreditCard(int id);
    }
}
