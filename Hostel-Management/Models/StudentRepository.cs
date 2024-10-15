using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostel_Management.Models
{
    public class StudentRepository : IStudent
    {
        private readonly HostelContext _context;

        public StudentRepository(HostelContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.Include(s => s.Room).Include(s => s.LeaveRequests).ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Include(s => s.Room).FirstOrDefault(s => s.StudentID == id);
        }

        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return student;
        }

        public Student DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return student;
        }

        public IEnumerable<Student> GetStudentsByRoomId(int roomId)
        {
            return _context.Students.Where(s => s.RoomID == roomId).ToList();
        }

        public IEnumerable<FeeHistory> GetFeeHistoryByStudentId(int studentId)
        {
            return _context.FeeHistories.Where(f => f.StudentID == studentId).ToList();
        }

    }
}
