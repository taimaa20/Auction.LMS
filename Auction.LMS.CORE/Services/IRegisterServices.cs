using Auction.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
   public  interface IRegisterServices
    {
        public bool InsertRegister(RegistorDTO registorDTO);
    }
}
