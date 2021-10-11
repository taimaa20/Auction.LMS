using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
    public interface ILoginService
    {
        public List<Login> GetAllLogin();

        public bool InsertLogin(Login login);
        public bool UpdateLogin(Login login);
        public bool DeleteLogin(int id);
        public Login GetLoginById(int id);
    }
}
