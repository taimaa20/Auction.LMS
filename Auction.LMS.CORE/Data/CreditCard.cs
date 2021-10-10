using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Auction.LMS.CORE.Data
{
  public  class CreditCard
    {

        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int CustomerId { get; set; }
        public double Balance { get; set; }
        public int PaymentId { get; set; }

        [ForeignKey("CustomerId")]

        public virtual Customer Customer { get; set; }

        [ForeignKey("PaymentId")]

        public virtual Payment Payment { get; set; }


    }
}
