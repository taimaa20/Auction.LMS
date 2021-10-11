using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
  public interface IPaymentRepoisitory
    {
        public List<Payment> GetAllPayments();

        public bool InsertPayment(Payment payment);
        public bool UpdatePayment(Payment payment);
        public bool DeletePayment(int id);
        public Payment GetAllPaymentsById(int id);
        public Payment GetPaymentByCustomerId(int id);
        public EmployeeCustomerPaymentInformationDTO EmployeeCustomerPaymentInformationDTO(int id);

    }
}
