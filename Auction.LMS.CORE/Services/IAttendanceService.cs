using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
  public  interface IAttendanceService
    {
        List<Attendance> GetAllAttendance();
        bool InsertAttendance(Attendance attendance);
        bool UpdateAttendance(Attendance attendance);
        bool DeleteAttendance(int Attendanceid);
    }
}
