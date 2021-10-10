using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Auction.LMS.CORE.Data
{
   public  class Home
    {
        [Key]
 
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImageName { get; set; }

        public string Story { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }


    }
}
