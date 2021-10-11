using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepoisitory homeRepoisitory;
        public HomeService(IHomeRepoisitory homeRepoisitory)
        {
            this.homeRepoisitory = homeRepoisitory;
        }
        
        public bool DeleteHome(int id)
        {
            return homeRepoisitory.DeleteHome(id);
        }

        public List<Home> GetAllHome()
        {
            return homeRepoisitory.GetAllHome();
        }

        public Home GetHomeById(int id)
        {
            return homeRepoisitory.GetHomeById(id);
        }

        public bool InsertHome(Home home)
        {
            return homeRepoisitory.InsertHome(home);
        }

        public bool UpdateHome(Home home)
        {
            return homeRepoisitory.UpdateHome(home);
        }
    }
}
