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
    public class SalaryController : ControllerBase
    {

        private readonly ISalaryService salaryService ;
        public SalaryController(ISalaryService salaryService)
        {
            this.salaryService = salaryService;
        }

        [HttpGet]
        public List<Salary> GetAllSalaries()
        {
            return salaryService.GetAllSalaries();
        }

        [HttpPost]
        public bool InsertSalary([FromBody]Salary salary)
        {
            return salaryService.InsertSalary(salary);
        }
        [HttpPut]
        public bool UpdateSalary(Salary salary)
        {
            return salaryService.UpdateSalary(salary);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteSalary(int id)
        {
            return salaryService.DeleteSalary(id);
        }
        [HttpGet]
        [Route("getsalarybyid/{id}")]
        public Salary GetSalaryById(int id)
        {
            return salaryService.GetSalaryById(id);
        }
        [HttpGet]
        [Route("GetSalaryByEmployeeId/{id}")]
        public Salary GetSalaryByEmployeeId(int id)
        {
            return salaryService.GetSalaryByEmployeeId(id);
        }
    }
}
