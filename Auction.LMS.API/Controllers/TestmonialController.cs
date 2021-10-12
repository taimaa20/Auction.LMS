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
    public class TestmonialController : ControllerBase
    {
        private readonly ITestmonialService testmonialService ;
        public TestmonialController(ITestmonialService testmonialService)
        {
            this.testmonialService = testmonialService;
        }
        [HttpGet]
        public List<Testmonial> GetAllTestmonials()
        {
            return testmonialService.GetAllTestmonials();
        }
        [HttpPost]
        public bool InsertTestemonial([FromBody]Testmonial testmonial)
        {
            return testmonialService.InsertTestemonial(testmonial);
        }
        [HttpPut]
        public bool UpdateTestmonial(Testmonial testmonial)
        {
            return testmonialService.UpdateTestmonial(testmonial);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteTestmonial(int id)
        {
            return testmonialService.DeleteTestmonial(id);
        }
        [HttpGet]
        [Route("gettestmonialbyid/{id}")]
        public Testmonial GetTestemonialById(int id)
        {
            return testmonialService.GetTestemonialById(id);
        }
    }
}
