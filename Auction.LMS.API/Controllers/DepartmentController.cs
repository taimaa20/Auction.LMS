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
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService departmentService;
        public DepartmentController(IDepartmentService _departmentService)
        {
            departmentService = _departmentService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Department>), StatusCodes.Status200OK)]
        public List<Department> GetAllDepartment()
        {
            return departmentService.GetAllDepartment();
        }
        [HttpPost]
        public bool InsertDepartment([FromBody] Department department)
        {
            return departmentService.InsertDepartment(department);
        }
        [HttpPut]
        public bool UpdateDepartment(Department department)
        {
            return departmentService.UpdateDepartment(department);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteDepartment(int id)
        {
            return departmentService.DeleteDepartment(id);
        }
        [HttpGet]
        [Route("getdepartmentbyid/{id}")]
        public Department GetAllDepartmentId(int id)
        {
            return departmentService.GetAllDepartmentId(id);
        }

    }
}
