using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Text;

namespace Auction.LMS.CORE.Data
{
   public class Login
    {
        [Key]
     
        public int Id { get; set; }
        public string UserName { get; set; }
      
        public string Password { get; set; }
        public int DeptId { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }

        [ForeignKey("CustomerId")]

        public virtual Customer Customer { get; set; }

        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }

        [ForeignKey("DeptId")]

        public virtual Department Department { get; set; }


    }
}
