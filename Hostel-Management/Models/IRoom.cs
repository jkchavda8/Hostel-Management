using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hostel_Management.Models
{
    public interface IRoom
    {
        public IEnumerable<Room> GetAllRooms();
        public Room GetRoomById(int id);
        public IEnumerable<Room> GetAvailableRooms();
        public Room AddRoom(Room room);
        public Room UpdateRoom(Room room);
        public Room DeleteRoom(int id);
    }
}
