using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class SalaryService : ISalaryService
    {
        private readonly ISalaryRepoisitory salaryRepoisitory ;
        public SalaryService(ISalaryRepoisitory salaryRepoisitory)
        {
            this.salaryRepoisitory = salaryRepoisitory;
        }
        public bool DeleteSalary(int id)
        {
            return salaryRepoisitory.DeleteSalary(id);
        }

        public List<Salary> GetAllSalaries()
        {
            return salaryRepoisitory.GetAllSalaries();
        }

        public Salary GetSalaryByEmployeeId(int id)
        {
            return salaryRepoisitory.GetSalaryByEmployeeId(id);
        }

        public Salary GetSalaryById(int id)
        {
            return salaryRepoisitory.GetSalaryById(id);
        }

        public bool InsertSalary(Salary salary)
        {
            return salaryRepoisitory.InsertSalary(salary);
        }

        public bool UpdateSalary(Salary salary)
        {
            return salaryRepoisitory.UpdateSalary(salary);
        }
    }
}
