using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.LMS.API.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Employee>), StatusCodes.Status200OK)]
        public List<Employee> GetAllEmployee()
        {
            return employeeService.GetAllEmployee();
        }
        [HttpPost]
        public bool InsertEmployee([FromBody] Employee employee)
        {
            return employeeService.InsertEmployee(employee);
        }
        [HttpPut]
        public bool UpdateEmployee(Employee employee)
        {
            return employeeService.UpdateEmployee(employee);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteEmployee(int id)
        {
            return employeeService.DeleteEmployee(id);
        }
        [HttpGet]
        [Route("getemployeebyid/{id}")]
        public Employee GetAllEmployeeId(int id)
        {
            return employeeService.GetAllEmployeeId(id);
        }
        [HttpPost]
        [Route("SearchEmployeeByName")]
        public List<Employee> SearchEmployeeByName(Employee employee)
        {
            return employeeService.SearchEmployeeByName(employee);
        }
        [HttpGet]
        [Route("CountEmployee")]
        public IEnumerable<EmployeeCountDTO> CountEmployee()
        {
            return employeeService.CountEmployee();
        }
        [HttpGet]
        [Route("EmployeeSalaryInformation")]
        public List<EmployeeSalaryInformationDTO> EmployeeSalaryInformation(EmployeeSalaryInformationDTO employeeSalaryInformationDTO)
        {
            return employeeService.EmployeeSalaryInformation(employeeSalaryInformationDTO);
        }


    }
}
