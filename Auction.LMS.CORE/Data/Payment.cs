using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Auction.LMS.CORE.Data
{
  public class Payment
    {
        [Key]
        
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public double PaymentAmount { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        public int ItemId { get; set; }

        [ForeignKey("CustomerId")]

        public virtual Customer Customer { get; set; }

        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }

        [ForeignKey("ItemId")]

        public virtual Item Item { get; set; }

        public ICollection<CreditCard> CreditCard
        {

            get; set;
        }
    }
}
