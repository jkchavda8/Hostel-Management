using Hostel_Management.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hostel_Management.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _studentRepository;
        private readonly IRoom _roomRepository;
        private readonly IFeeHistory _history;

        public StudentController(IStudent studentRepository,IRoom roomRepository, IFeeHistory history)
        {
            _studentRepository = studentRepository;
            _roomRepository = roomRepository;
            _history = history;
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
            var currentYear = DateTime.Now.Year;

            // Check if the student has any fee history for the current year
            var currentYearFeeHistory = _history.GetAllFeeHistories()
                                                .Where(f => f.StudentID == id && f.year == currentYear)
                                                .ToList();

            // If no fee history for the current year, the fee is pending
            bool isFeePending = !currentYearFeeHistory.Any();

            // Pass fee status to the view
            ViewBag.IsFeePending = isFeePending;

            var roomDetails = _roomRepository.GetRoomById(student.RoomID); // Ensure this method is available
            ViewBag.RoomDetails = roomDetails;

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
                Text = $"{r.RoomNumber} - Capacity: {r.Capacity}, Beds: {r.NumberOfBeds}, Fans: {r.NumberOfFans}, Tables: {r.NumberOfTables}, Chairs: {r.NumberOfChairs}"
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

            // Create a list of SelectListItem with detailed room information
            var availableRooms = _roomRepository.GetAvailableRooms().Select(r => new SelectListItem
            {
                Value = r.RoomID.ToString(),
                Text = $"{r.RoomNumber} - Capacity: {r.Capacity}, Beds: {r.NumberOfBeds}, Fans: {r.NumberOfFans}, Tables: {r.NumberOfTables}, Chairs: {r.NumberOfChairs}"
            }).ToList();

            ViewBag.RoomID = new SelectList(availableRooms, "Value", "Text", student.RoomID);
            var roomDetails = _roomRepository.GetRoomById(student.RoomID); // Ensure this method is available
            ViewBag.RoomDetails = roomDetails;
            return View(student);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                // Fetch the current student record from the database
                var currentStudent = _studentRepository.GetStudentById(student.StudentID);

                if (currentStudent == null)
                {
                    return NotFound();
                }

                // Check if the room has changed
                if (currentStudent.RoomID != student.RoomID)
                {
                    // Fetch the old room
                    var oldRoom = _roomRepository.GetRoomById(currentStudent.RoomID);
                    if (oldRoom != null)
                    {
                        // Remove the student from the old room's student collection
                        oldRoom.Students.Remove(currentStudent);

                        // Update the occupancy status of the old room
                        oldRoom.IsOccupied = oldRoom.Students.Count >= oldRoom.Capacity;

                        // Save the changes to the old room
                        _roomRepository.UpdateRoom(oldRoom);
                    }

                    // Fetch the new room
                    var newRoom = _roomRepository.GetRoomById(student.RoomID);
                    if (newRoom != null)
                    {
                        // Add the student to the new room's student collection
                        newRoom.Students.Add(currentStudent); // Use the currentStudent here, not the "student" from the form

                        // Update the occupancy status of the new room
                        newRoom.IsOccupied = newRoom.Students.Count >= newRoom.Capacity;

                        // Save the changes to the new room
                        _roomRepository.UpdateRoom(newRoom);
                    }
                }

                // Update the student's other details except RoomID (if room has changed, it was already handled)
                currentStudent.Name = student.Name;
                currentStudent.Email = student.Email;
                currentStudent.Password = student.Password;
                currentStudent.DOB = student.DOB;
                currentStudent.EntryDate = student.EntryDate;
                currentStudent.RoomID = student.RoomID;
                currentStudent.IsAdmitted = student.IsAdmitted;

                _studentRepository.UpdateStudent(currentStudent);

                return RedirectToAction("Index");
            }

            // If model state is invalid, reload the rooms list for the dropdown and return the view
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

        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // Clear the session
            return RedirectToAction("Index", "Home"); // Redirect to home page or login page
        }

    }
}
