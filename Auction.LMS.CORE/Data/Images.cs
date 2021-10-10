using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Auction.LMS.CORE.Data
{
    public class Images
    {
        [Key]

        public int Id { get; set; }
        public string ImageName { get; set; }
        public int ItemId { get; set; }

        [ForeignKey("ItemId")]

        public virtual Item Item { get; set; }

    }
}
