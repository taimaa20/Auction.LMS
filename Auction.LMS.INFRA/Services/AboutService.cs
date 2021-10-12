using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository aboutRepository ;
        public AboutService(IAboutRepository aboutRepository)
        {
            this.aboutRepository = aboutRepository;
        }
        public bool DeleteAbout(int id)
        {
            return aboutRepository.DeleteAbout(id);
        }

        public List<About> GetAllAbout()
        {
            return aboutRepository.GetAllAbout();
        }

        public bool InsertAbout(About about)
        {
            return aboutRepository.InsertAbout(about);
        }

        public bool UpdateAbout(About about)
        {
            return aboutRepository.UpdateAbout(about);
        }
        public About GetAllAboutId(int id)
        {
            return aboutRepository.GetAllAboutId(id);
        }
    }
}
