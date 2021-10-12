using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.DTO;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
   public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository  ;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IEnumerable<EmployeeCountDTO> CountEmployee()
        {
            return employeeRepository.CountEmployee();
        }

        public bool DeleteEmployee(int id)
        {
            return employeeRepository.DeleteEmployee(id);
        }

        public List<EmployeeSalaryInformationDTO> EmployeeSalaryInformation(EmployeeSalaryInformationDTO employeeSalaryInformationDTO)
        {
            return employeeRepository.EmployeeSalaryInformation(employeeSalaryInformationDTO);
        }

        public List<Employee> GetAllEmployee()
        {
            return employeeRepository.GetAllEmployee();
        }

        public bool InsertEmployee(Employee employee)
        {
            return employeeRepository.InsertEmployee(employee);
        }

        public List<Employee> SearchEmployeeByName(Employee employee)
        {
            return employeeRepository.SearchEmployeeByName(employee);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return employeeRepository.UpdateEmployee(employee);
        }
        public Employee GetAllEmployeeId(int id)
        {
            return employeeRepository.GetAllEmployeeId(id);
        }
    }
}
