using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hostel_Management.Models
{
    public interface IStudent
    {
        public IEnumerable<Student> GetAllStudents();
        public Student GetStudentById(int id);
        public Student AddStudent(Student student);
        public Student UpdateStudent(Student student);
        public Student DeleteStudent(int id);
        public IEnumerable<Student> GetStudentsByRoomId(int roomId);
        public IEnumerable<FeeHistory> GetFeeHistoryByStudentId(int studentId);
    }
}
