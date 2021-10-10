using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Auction.LMS.CORE.Data
{
   public class Item
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public int CategoryId { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CategoryId")]

        public virtual Category Category { get; set; }

        [ForeignKey("CustomerId")]

        public virtual Customer Customer { get; set; }

        public ICollection<Payment> Payment
        {

            get; set;
        }

        public ICollection<Images> Images
        {

            get; set;
        }

        public ICollection<Auction1> Auction
        {

            get; set;
        }
    }
}
