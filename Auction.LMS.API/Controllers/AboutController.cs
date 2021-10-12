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
    public class AboutController : ControllerBase
    {
        private readonly IAboutService aboutService;
        public AboutController(IAboutService _aboutService)
        {
            aboutService = _aboutService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<About>), StatusCodes.Status200OK)]
        public List<About> GetAllAbout()
        {
            return aboutService.GetAllAbout();
        }
        [HttpPost]
        public bool InsertAbout([FromBody] About about)
        {
            return aboutService.InsertAbout(about);
        }
        [HttpPut]
        public bool UpdateAbout(About about)
        {
            return aboutService.UpdateAbout(about);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteAbout(int id)
        {
            return aboutService.DeleteAbout(id);
        }
        [HttpGet]
        [Route("getaboutbyid/{id}")]
        public About GetAllAboutId(int id)
        {
            return aboutService.GetAllAboutId(id);
        }

    }
}
