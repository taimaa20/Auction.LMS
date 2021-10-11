using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository attendanceRepository;
        public AttendanceService(IAttendanceRepository attendanceRepository)
        {
            this.attendanceRepository = attendanceRepository;
        }
        public bool DeleteAttendance(int Attendanceid)
        {
            return attendanceRepository.DeleteAttendance(Attendanceid);
        }

        public List<Attendance> GetAllAttendance()
        {
            return attendanceRepository.GetAllAttendance();
        }

        public bool InsertAttendance(Attendance attendance)
        {
            return attendanceRepository.InsertAttendance(attendance);
        }

        public bool UpdateAttendance(Attendance attendance)
        {
            return attendanceRepository.UpdateAttendance(attendance);
        }
    }
}
