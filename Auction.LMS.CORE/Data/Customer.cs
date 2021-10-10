using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Auction.LMS.CORE.Data
{
    public class Customer
    {
        [Key]

        public int Id { get; set; }
        public int Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ImageName { get; set; }
        public int MyProperty { get; set; }

        public ICollection<Item> Item
        {

            get; set;
        }

        public ICollection<CreditCard> CreditCard
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
        public ICollection<Auction1> Auction
        {

            get; set;
        }
        public ICollection<Payment> Payment
        {

            get; set;
        }

    }
}
