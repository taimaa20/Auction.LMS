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
    public class CreditCardController : Controller
    {
        private readonly ICreditCardService creditCardService;
        public CreditCardController(ICreditCardService _creditCardService)
        {
            creditCardService = _creditCardService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<CreditCard>), StatusCodes.Status200OK)]
        public List<CreditCard> GetAllCreditCard()
        {
            return creditCardService.GetAllCreditCard();
        }
        [HttpPost]
        public bool InsertCreditCard([FromBody] CreditCard creditCard)
        {
            return creditCardService.InsertCreditCard(creditCard);
        }
        [HttpPut]
        public bool UpdateCreditCard(CreditCard creditCard)
        {
            return creditCardService.UpdateCreditCard(creditCard);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteCreditCard(int id)
        {
            return creditCardService.DeleteCreditCard(id);
        }
        [HttpGet]
        [Route("getcreditcardbyid/{id}")]
        public CreditCard GetAllCreditCardId(int id)
        {
            return creditCardService.GetAllCreditCardId(id);
        }

    }
}
