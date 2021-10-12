using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
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
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService paymentService ;
        public PaymentController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        [HttpGet]
        public List<Payment> GetAllPayments()
        {
            return paymentService.GetAllPayments();
        }

        [HttpPost]
        public bool InsertPayment([FromBody]Payment payment)
        {
            return paymentService.InsertPayment(payment);
        }

        [HttpPut]
        public bool UpdatePayment(Payment payment)
        {
            return paymentService.UpdatePayment(payment);
        }

        [HttpDelete("delete/{id}")]
        public bool DeletePayment(int id)
        {
            return paymentService.DeletePayment(id);
        }
        [HttpGet]
        [Route("getpaymentbyid/{id}")]
        public Payment GetAllPaymentsById(int id)
        {
            return paymentService.GetAllPaymentsById(id);
        }
        [HttpGet]
        [Route("GetPaymentByCustomerId/{id}")]
        public Payment GetPaymentByCustomerId(int id)
        {
            return paymentService.GetPaymentByCustomerId(id);
        }
        [HttpGet]
        [Route("EmployeeCustomerPaymentInformationDTO/{id}")]
        public EmployeeCustomerPaymentInformationDTO EmployeeCustomerPaymentInformationDTO(int id)
        {
            return paymentService.EmployeeCustomerPaymentInformationDTO(id);
        }

    }
}
