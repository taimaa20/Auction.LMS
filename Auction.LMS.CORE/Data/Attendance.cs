using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Auction.LMS.CORE.Data
{
   public class Attendance
    {
        [Key]

        public int AttendanceId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }
    }
}
