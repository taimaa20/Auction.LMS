using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Auction.LMS.CORE.Data
{
    public class About
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Story { get; set; }

       
    }
}
