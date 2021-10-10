using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Auction.LMS.CORE.Data
{
   public class Auction1
    {
        [Key]

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Bidprice { get; set; }
        public double Commetion { get; set; }
        public double InitialPrice { get; set; }
        public double MarketEstimated { get; set; }
        public string Status { get; set; }
        public int EmployeeId { get; set; }
        public int ItemId { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]

        public virtual Customer Customer { get; set; }

        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }

        [ForeignKey("ItemId")]

        public virtual Item Item { get; set; }
    }
}
