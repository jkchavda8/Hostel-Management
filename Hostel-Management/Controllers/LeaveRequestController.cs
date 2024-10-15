using Hostel_Management.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hostel_Management.Controllers
{
    public class LeaveRequestController : Controller
    {
        private readonly ILeaveRequest _leaveRequestRepository;
        private readonly IStudent _studentRepository;

        public LeaveRequestController(ILeaveRequest leaveRequestRepository,IStudent studentrepo)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _studentRepository = studentrepo;
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var leaveRequest = _leaveRequestRepository.GetLeaveRequestById(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }
            return View(leaveRequest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LeaveRequest leaveRequest)
        {
            if (ModelState.IsValid)
            {
                _leaveRequestRepository.UpdateLeaveRequest(leaveRequest); // Ensure this method exists
                return RedirectToAction("Index");
            }
            return View(leaveRequest);
        }


        [HttpGet]
        public IActionResult RequestLeave()
        {
            var studentIdString = HttpContext.Session.GetString("StudentID");
            if (string.IsNullOrEmpty(studentIdString))
            {
                return RedirectToAction("Login", "Student"); // Redirect to login if session is not available
            }

            int studentId = int.Parse(studentIdString);

            // Ensure the student exists in the database
            var existingStudent = _studentRepository.GetStudentById(studentId);
            if (existingStudent == null)
            {
                // Handle the case where the student does not exist
                ModelState.AddModelError("", "Invalid Student ID. Please log in again.");
                return RedirectToAction("Login", "Student");
            }

            var leaveRequest = new LeaveRequest
            {
                StudentID = studentId,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1) // Default to 1-day leave for now
            };

            return View("CreateLeaveRequest", leaveRequest);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateLeaveRequest(LeaveRequest leaveRequest)
        {
            // Assume you are getting StudentID from the session or some context
            var studentIdString = HttpContext.Session.GetString("StudentID");

            if (string.IsNullOrEmpty(studentIdString) || !int.TryParse(studentIdString, out int studentId))
            {
                ModelState.AddModelError("", "Student ID is not valid.");
                return View(leaveRequest);
            }

            leaveRequest.StudentID = studentId; // Set the student ID correctly

            // Check if the student exists
            var existingStudent = _studentRepository.GetStudentById(studentId);
            if (existingStudent == null)
            {
                ModelState.AddModelError("", "The specified student does not exist.");
                return View(leaveRequest);
            }

            if (ModelState.IsValid)
            {
                _leaveRequestRepository.AddLeaveRequest(leaveRequest);
                return RedirectToAction("Details", "Student", new { id = existingStudent.StudentID });
            }

            // If model validation fails, redisplay the form
            return View(leaveRequest);
        }


        public IActionResult Index()
        {
            var leaveRequests = _leaveRequestRepository.GetAllLeaveRequests();
            return View(leaveRequests);
        }

        public IActionResult Details(int id)
        {
            var leaveRequest = _leaveRequestRepository.GetLeaveRequestById(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }
            return View(leaveRequest);
        }

        public IActionResult Delete(int id)
        {
            var leaveRequest = _leaveRequestRepository.GetLeaveRequestById(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }
            return View(leaveRequest);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _leaveRequestRepository.DeleteLeaveRequest(id);
            return RedirectToAction("Index");
        }

        public IActionResult Approve(int id)
        {
            var leaveRequest = _leaveRequestRepository.ApproveLeaveRequest(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }

        public IActionResult MyLeaveRequest()
        {
            // Get the student ID from session
            var studentIdString = HttpContext.Session.GetString("StudentID");
            if (int.TryParse(studentIdString, out int studentId))
            {
                var leaveRequests = _leaveRequestRepository.GetAllLeaveRequests()
                    .Where(lr => lr.StudentID == studentId) // Filter by student ID
                    .ToList();

                return View(leaveRequests); // Pass leave requests to the view
            }

            return NotFound(); // Return not found if student ID is not valid
        }
    }
}
