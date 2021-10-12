using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository ;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
        public bool DeleteDepartment(int id)
        {
            return departmentRepository.DeleteDepartment(id);
        }

        public List<Department> GetAllDepartment()
        {
            return departmentRepository.GetAllDepartment();
        }

        public bool InsertDepartment(Department department)
        {
            return departmentRepository.InsertDepartment(department);
        }

        public bool UpdateDepartment(Department department)
        {
            return departmentRepository.UpdateDepartment(department);
        }
        public Department GetAllDepartmentId(int id)
        {
            return departmentRepository.GetAllDepartmentId(id);
        }
    }
}
