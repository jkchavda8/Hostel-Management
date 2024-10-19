using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostel_Management.Models
{
    public class LeaveRequestRepository : ILeaveRequest
    {
        private readonly HostelContext _context;

        public LeaveRequestRepository(HostelContext context)
        {
            _context = context;
        }

        public IEnumerable<LeaveRequest> GetAllLeaveRequests()
        {
            return _context.LeaveRequests.Include(l => l.Student).ToList();
        }

        public LeaveRequest GetLeaveRequestById(int id)
        {
            return _context.LeaveRequests.Include(l => l.Student).FirstOrDefault(l => l.LeaveRequestID == id);
        }

        public LeaveRequest AddLeaveRequest(LeaveRequest leaveRequest)
        {
            _context.LeaveRequests.Add(leaveRequest);
            _context.SaveChanges();
            return leaveRequest;
        }

        public LeaveRequest ApproveLeaveRequest(int id)
        {
            var leaveRequest = _context.LeaveRequests.Find(id);
            if (leaveRequest != null)
            {
                leaveRequest.ApprovedByAdmin = true;
                _context.SaveChanges();
            }
            return leaveRequest;
        }

        public LeaveRequest DeleteLeaveRequest(int id)
        {
            var leaveRequest = _context.LeaveRequests.Find(id);
            if (leaveRequest != null)
            {
                _context.LeaveRequests.Remove(leaveRequest);
                _context.SaveChanges();
            }
            return leaveRequest;
        }

        public void UpdateLeaveRequest(LeaveRequest leaveRequest)
        {
            // Check if the LeaveRequest exists
            var existingLeaveRequest = _context.LeaveRequests.AsNoTracking()
                                            .FirstOrDefault(lr => lr.LeaveRequestID == leaveRequest.LeaveRequestID);

            if (existingLeaveRequest != null)
            {
                // Mark the entity as modified
                _context.Entry(leaveRequest).State = EntityState.Modified;
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"Leave request with ID {leaveRequest.LeaveRequestID} not found.");
            }
        }

    }
}
