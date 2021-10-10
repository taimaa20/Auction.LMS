using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Auction.LMS.CORE.Data
{
   public class Message
    {
        [Key]
   
        public int Id { get; set; }
        public string SendMessage { get; set; }
        public string ReplayMessage { get; set; }
        public DateTime MessageDate { get; set; }
        public int? CustomerId { get; set; }

        public int? EmployeeId { get; set; }

        [ForeignKey("CustomerId")]

        public virtual Customer Customer { get; set; }

        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }

    }
}
