using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAttendanceSystem.Models
{
    public class Attendance
    {
        [Key]
        public string AttendanceId { get; set; }

        public string AttendanceStatus { get; set; }

        public string AttendanceDate { get; set; }

      
       
    }
}