﻿using Hostel_Management.Models;
using Hostel_Management.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hostel_Management.Controllers
{
    public class FeeHistoryController : Controller
    {
        private readonly IFeeHistory _feeHistoryRepository;
        private readonly IStudent _studentRepository;

        public FeeHistoryController(IFeeHistory feeHistoryRepository, IStudent studentRepository)
        {
            _feeHistoryRepository = feeHistoryRepository;
            _studentRepository = studentRepository;
        }

        // Display fee history for a student
        public IActionResult Index(int studentId)
        {
            var feeHistories = _feeHistoryRepository.GetAllFeeHistories().Where(f => f.StudentID == studentId);
            ViewBag.StudentId = studentId;
            return View(feeHistories);
        }
        public IActionResult Details(int studentId)
        {
            var feeHistories = _feeHistoryRepository.GetAllFeeHistories().Where(f => f.StudentID == studentId).ToList();

            // Check if no fee history is found and return NotFound
            if (feeHistories == null || !feeHistories.Any())
            {
                ViewBag.StudentId = studentId; // Still pass the student ID to the view
                return View(new List<FeeHistory>()); // Pass an empty list
            }

            ViewBag.StudentId = studentId; // Pass the student ID to the view
            return View(feeHistories);
        }


        // Show add fee form
        public IActionResult Create(int studentId)
        {
            ViewBag.StudentId = studentId;
            return View();
        }

        // Add fee to database
        [HttpPost]
        public IActionResult Create(FeeHistory feeHistory)
        {
            if (ModelState.IsValid)
            {
                _feeHistoryRepository.AddFeeHistory(feeHistory);
                return RedirectToAction("Index", new { studentId = feeHistory.StudentID });
            }
            return View(feeHistory);
        }
        public IActionResult PendingFees()
        {
            var currentYear = DateTime.Now.Year;

            // Fetch all students
            var allStudents = _studentRepository.GetAllStudents().ToList();

            // Fetch fee histories for all students
            var allFeeHistories = _feeHistoryRepository.GetAllFeeHistories().ToList();

            // Students who have paid for the current year
            var studentsWithCurrentYearFees = allFeeHistories
                                                .Where(f => f.year == currentYear)
                                                .Select(f => f.StudentID)
                                                .ToList();

            // Get students who have paid in any previous year but not this year
            var studentsWithPendingFees = allStudents
                .Where(s => !studentsWithCurrentYearFees.Contains(s.StudentID))
                .ToList();

            return View(studentsWithPendingFees);
        }

    }
}
