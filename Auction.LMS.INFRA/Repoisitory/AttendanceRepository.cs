using Auction.LMS.CORE.Common;
using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Auction.LMS.INFRA.Repoisitory
{
   public class AttendanceRepository: IAttendanceRepository
    {
        private readonly IDBContext DbContext;
        public AttendanceRepository(IDBContext _DbContext)
        {
            DbContext = _DbContext;
        }
        //public List<Attendance> GetAllAttendence()
        //{
        //    IEnumerable<Attendance> result =DbContext.Connection.Query<Attendance>("GetAllAttendence", commandType: CommandType.StoredProcedure);
        //    return result.ToList();
        //}
        public bool InsertAttendance(Attendance attendance)
        {
            var p = new DynamicParameters();
            p.Add("@CheckIn", attendance.CheckIn, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@CheckOut", attendance.CheckOut, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@EmployeeId", attendance.EmployeeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("InsertAttendence", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateAttendance(Attendance attendance)
        {
            var p = new DynamicParameters();
            p.Add("@AttendanceId", attendance.AttendanceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CheckIn", attendance.CheckIn, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@CheckOut", attendance.CheckOut, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@EmployeeId", attendance.EmployeeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("UpdateAttendence", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteAttendance(int Attendanceid)
        {
            var p = new DynamicParameters();
            p.Add("@AttendanceId", Attendanceid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("DeleteAttendance", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Attendance> GetAllAttendance()
        {
            IEnumerable<Attendance> result = DbContext.Connection.Query<Attendance>("GetAllAttendence", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public Attendance GetAllAttendanceId(int Attendanceid)
        {
            var p = new DynamicParameters();
            p.Add("@AttendanceId", Attendanceid, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = DbContext.Connection.Query<Attendance>("GetByIdAttendance", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
