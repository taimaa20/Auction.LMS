using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Auction.LMS.CORE.Data
{
    public class Employee
    {
        [Key]
  
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int DeptId { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string ImageName { get; set; }

        public ICollection<Attendance> Attendance
        {

            get; set;
        }

        public ICollection<Salary> Salary
        {

            get; set;
        }

        public ICollection<Payment> Payment
        {

            get; set;
        }
        public ICollection<Message> Message
        {

            get; set;
        }

        public ICollection<Login> Login
        {

            get; set;
        }

        [ForeignKey("DeptId")]

        public virtual Department Department { get; set; }

        public ICollection<Auction1> Auction
        {

            get; set;
        }

    }
}
