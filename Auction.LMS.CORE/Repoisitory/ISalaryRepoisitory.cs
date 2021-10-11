using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
   public interface ISalaryRepoisitory
    {
        public List<Salary> GetAllSalaries();

        public bool InsertSalary(Salary salary );
        public bool UpdateSalary(Salary salary );
        public bool DeleteSalary(int id);
        public Salary GetSalaryById(int id);
        public Salary GetSalaryByEmployeeId(int id);
    }
}
