using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
   public interface IHomeService
    {
        public List<Home> GetAllHome();

        public bool InsertHome(Home home);
        public bool UpdateHome(Home home);
        public bool DeleteHome(int id);
        public Home GetHomeById(int id);
    }
}
