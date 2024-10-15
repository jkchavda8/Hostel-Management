using System.Collections.Generic;

namespace Hostel_Management.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public int NumberOfBeds { get; set; }
        public int NumberOfFans { get; set; }
        public int NumberOfTables { get; set; }
        public int NumberOfChairs { get; set; }
        public bool IsOccupied { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
