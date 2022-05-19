using EmployeeAttendanceSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAttendanceSystem.Services.AttendanceServices
{
    public class AttendanceService : IAttendanceService
    {
        public static readonly List<Attendance> attendances = new List<Attendance>()
        {
            new Attendance {AttendanceId ="A1",AttendanceStatus="Prsent",AttendanceDate="10-05-2022"},

            new Attendance {AttendanceId ="A2",AttendanceStatus="Absent",AttendanceDate="11-05-2022"},
        };


        public async Task<IEnumerable<Attendance>> GetAttendances()
        {
            return attendances;
        }

        public async Task<Attendance> GetAttendanceById(string attendanceId)
        {
            var result = attendances.SingleOrDefault(a => a.AttendanceId == attendanceId);
            return result;
        }

        public async Task<Attendance> CreateAttendance(Attendance attendanceObj)
        {
            attendances.Add(attendanceObj);
            return attendanceObj;
        }

        public async Task<Attendance> DeleteAttendance(string attendanceId)
        {
            var result = attendances.Find(a => a.AttendanceId == attendanceId);
            if (result != null)
            {
                attendances.Remove(result);

            }
            return result;
        }

        public async Task<Attendance> UpdateAttendance(Attendance attendanceObj)
        {
            var result = attendances.Find(a => a.AttendanceId == attendanceObj.AttendanceId);

            if (result != null)
            {
                result.AttendanceId = attendanceObj.AttendanceId;
                result.AttendanceStatus = attendanceObj.AttendanceStatus;
                result.AttendanceDate = attendanceObj.AttendanceDate;

                return result;
            }
            return null;
        }
    }

}