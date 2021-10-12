using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginService;
        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        [HttpGet]
        public List<Login> GetAllLogin()
        {
            return loginService.GetAllLogin();
        }

        [HttpPost]
        public bool InsertLogin([FromBody]Login login)
        {
            return loginService.InsertLogin(login);
        }
        [HttpPut]
        public bool UpdateLogin(Login login)
        {
            return loginService.UpdateLogin(login);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteLogin(int id)
        {
            return loginService.DeleteLogin(id);
        }

        [HttpGet]
        [Route("getloginbyid/{id}")]
        public Login GetLoginById(int id)
        {
            return loginService.GetLoginById(id);
        }
    }
}
