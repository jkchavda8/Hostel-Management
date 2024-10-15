using Hostel_Management.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Hostel_Management.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _studentRepository;
        private readonly IRoom _roomRepository;

        public StudentController(IStudent studentRepository,IRoom roomRepository)
        {
            _studentRepository = studentRepository;
            _roomRepository = roomRepository;
        }

        public IActionResult Index()
        {
            var students = _studentRepository.GetAllStudents();
            return View(students);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Student/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var student = _studentRepository.GetAllStudents().FirstOrDefault(s => s.Email == model.Email && s.Password == model.Password);

                if (student != null)
                {
                     HttpContext.Session.SetString("StudentID", student.StudentID.ToString());

                    return RedirectToAction("Details", new { id = student.StudentID }); // Redirect to Student's Dashboard after login
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }

            return View(model);
        }


        public IActionResult Details(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        public IActionResult Add()
        {
            var rooms = _roomRepository.GetAvailableRooms().Select(r => new SelectListItem
            {
                Value = r.RoomID.ToString(),
                Text = r.Capacity.ToString()
            }).ToList();

            ViewBag.RoomID = new SelectList(rooms, "Value", "Text");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentRepository.AddStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var rooms = _roomRepository.GetAvailableRooms().Select(r => new SelectListItem
            {
                Value = r.RoomID.ToString(),
                Text = r.Capacity.ToString(),
            }).ToList();

            ViewBag.RoomID = new SelectList(rooms, "Value", "Text");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                // Fetch the room, including its current list of students
                var room = _roomRepository.GetRoomById(student.RoomID);

                if (room == null)
                {
                    ModelState.AddModelError("", "Room not found.");
                    return View(student);
                }

                // Register the student
                _studentRepository.AddStudent(student);

                // Add the student to the room's Students collection
                room.Students.Add(student);

                // Update the IsOccupied status based on the room's capacity
                room.IsOccupied = room.Students.Count >= room.Capacity;

                // Save the changes to the room
                _roomRepository.UpdateRoom(room);

                // Optionally, log the student in after registration
                HttpContext.Session.SetString("StudentID", student.StudentID.ToString());

                return RedirectToAction("Details", new { id = student.StudentID });
            }

            return View(student);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewBag.RoomID = new SelectList(_roomRepository.GetAllRooms(), "RoomID", "Capacity"); // Adjust as necessary
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentRepository.UpdateStudent(student); // Ensure this method exists in your repository
                return RedirectToAction("Index");
            }
            ViewBag.RoomID = new SelectList(_roomRepository.GetAllRooms(), "RoomID", "Capacity", student.RoomID);
            return View(student);
        }


        public IActionResult Delete(int id)
        {
            var student = _studentRepository
                                .GetAllStudents() // or GetStudentById(id) if that method allows Include
                                 // Include the LeaveRequests
                                .FirstOrDefault(s => s.StudentID == id); if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentRepository.DeleteStudent(id);
            return RedirectToAction("Index");
        }

        public IActionResult FeeHistory(int id)
        {
            var feeHistory = _studentRepository.GetFeeHistoryByStudentId(id);
            return View(feeHistory);
        }
    }
}
