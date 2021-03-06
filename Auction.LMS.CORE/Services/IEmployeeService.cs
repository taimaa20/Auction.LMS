using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
   public interface IEmployeeService
    {
        public List<Employee> GetAllEmployee();
        public bool InsertEmployee(Employee employee);
        public bool UpdateEmployee(Employee employee);
        public bool DeleteEmployee(int id);
        public List<Employee> SearchEmployeeByName(Employee employee);
        public IEnumerable<EmployeeCountDTO> CountEmployee();
        public List<EmployeeSalaryInformationDTO> EmployeeSalaryInformation(EmployeeSalaryInformationDTO employeeSalaryInformationDTO);
        public Employee GetAllEmployeeId(int id);
    }
}
