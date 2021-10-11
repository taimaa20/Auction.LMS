using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepoisitory loginRepoisitory ;
        public LoginService(ILoginRepoisitory loginRepoisitory)
        {
            this.loginRepoisitory = loginRepoisitory;
        }
        public bool DeleteLogin(int id)
        {
            return loginRepoisitory.DeleteLogin(id);
        }

        public List<Login> GetAllLogin()
        {
            return loginRepoisitory.GetAllLogin();
        }

        public Login GetLoginById(int id)
        {
            return loginRepoisitory.GetLoginById(id);
        }

        public bool InsertLogin(Login login)
        {
            return loginRepoisitory.InsertLogin(login);
        }

        public bool UpdateLogin(Login login)
        {
            return loginRepoisitory.UpdateLogin(login);
        }
    }
}
