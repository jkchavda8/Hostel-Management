using System.Collections.Generic;
using System;

namespace Hostel_Management.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime EntryDate { get; set; }
        public ICollection<FeeHistory> FeeHistories { get; set; }
        public bool IsAdmitted { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public int RoomID { get; set; }
        public Room Room { get; set; }

        public ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
    }
}
