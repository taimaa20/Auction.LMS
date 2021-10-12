using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class RegisterService: IRegisterServices
    {
        private readonly IRegisterRepository registerRepository;
        public RegisterService(IRegisterRepository registerRepository)
        {
            this.registerRepository = registerRepository;
        }

        public bool InsertRegister(RegistorDTO registorDTO)
        {
            return registerRepository.InsertRegister(registorDTO);
        }
    }
}
