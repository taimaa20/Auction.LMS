using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepoisitory paymentRepoisitory ;
        public PaymentService(IPaymentRepoisitory paymentRepoisitory)
        {
            this.paymentRepoisitory = paymentRepoisitory;
        }
        public bool DeletePayment(int id)
        {
            return paymentRepoisitory.DeletePayment(id);
        }

        public EmployeeCustomerPaymentInformationDTO EmployeeCustomerPaymentInformationDTO(int id)
        {
            return paymentRepoisitory.EmployeeCustomerPaymentInformationDTO(id);
        }

        public List<Payment> GetAllPayments()
        {
            return paymentRepoisitory.GetAllPayments();
        }

        public Payment GetAllPaymentsById(int id)
        {
            return paymentRepoisitory.GetAllPaymentsById(id);
        }

        public Payment GetPaymentByCustomerId(int id)
        {
            return paymentRepoisitory.GetPaymentByCustomerId(id);
        }

        public bool InsertPayment(Payment payment)
        {
            return paymentRepoisitory.InsertPayment(payment);
        }

        public bool UpdatePayment(Payment payment)
        {
            return paymentRepoisitory.UpdatePayment(payment);
        }
    }
}
