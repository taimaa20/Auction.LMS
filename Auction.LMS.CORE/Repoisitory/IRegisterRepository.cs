using Auction.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
  public  interface IRegisterRepository
    {
       public bool InsertRegister(RegistorDTO registorDTO);
    }
}
