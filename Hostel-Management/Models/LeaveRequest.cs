using System;

namespace Hostel_Management.Models
{
    public class LeaveRequest
    {
        public int LeaveRequestID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool ApprovedByAdmin { get; set; }

        public string reason {  get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}
