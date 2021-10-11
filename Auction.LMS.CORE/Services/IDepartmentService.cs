﻿using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
   public interface IDepartmentService
    {
        public List<Department> GetAllDepartment();

        public bool InsertDepartment(Department department);
        public bool UpdateDepartment(Department department);
        public bool DeleteDepartment(int id);
    }
}
