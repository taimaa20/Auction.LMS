using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
  public  interface IJwtRepository
    {
        public Login Auth(Login login);
    }
}
