using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
   public interface IAboutRepository
    {
        List<About> GetAllAbout();
        bool InsertAbout(About about);
        bool UpdateAbout(About about);
        bool DeleteAbout(int id);
    }
}
