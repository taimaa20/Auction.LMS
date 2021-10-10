using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Auction.LMS.CORE.Data
{
   public class Salary
    {
        [Key]
 
        public int SalaryId { get; set; }
        public int salary { get; set; }
        public int Tracks { get; set; }
        public int Incentives { get; set; }
        public DateTime MonthOfSalary { get; set; }
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }
    }
}
