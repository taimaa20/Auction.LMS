using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
 public   interface IJwtService
    {
        public string Auth(Login login);
    }
}
