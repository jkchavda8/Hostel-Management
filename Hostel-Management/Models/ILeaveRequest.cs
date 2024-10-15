using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hostel_Management.Models
{
    public interface ILeaveRequest
    {
        public IEnumerable<LeaveRequest> GetAllLeaveRequests();
        public LeaveRequest GetLeaveRequestById(int id);
        public LeaveRequest AddLeaveRequest(LeaveRequest leaveRequest);
        public LeaveRequest ApproveLeaveRequest(int id);
        public LeaveRequest DeleteLeaveRequest(int id);
        void UpdateLeaveRequest(LeaveRequest leaveRequest);
    }
}
