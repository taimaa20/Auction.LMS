using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
   public interface IAttendanceRepository
    {
        List<Attendance> GetAllAttendance();
        bool InsertAttendance(Attendance attendance);
        bool UpdateAttendance(Attendance attendance);
        bool DeleteAttendance(int Attendanceid);
        public Attendance GetAllAttendanceId(int id);
    }
}
