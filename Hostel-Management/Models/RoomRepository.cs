using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostel_Management.Models
{
    public class RoomRepository : IRoom
    {
        private readonly HostelContext _context;

        public RoomRepository(HostelContext context)
        {
            _context = context;
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _context.Rooms.ToList();
        }

        public Room GetRoomById(int id)
        {
            //return _context.Rooms.Find(id);
            return _context.Rooms
                   .Include(r => r.Students) // Eagerly load the Students collection
                   .FirstOrDefault(r => r.RoomID == id);
        }

        public IEnumerable<Room> GetAvailableRooms()
        {
            return _context.Rooms.Where(r => !r.IsOccupied).ToList();
        }

        public Room AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
            return room;
        }

        public Room UpdateRoom(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            _context.Rooms.Update(room);
            _context.SaveChanges();
            return room;
        }

        public Room DeleteRoom(int id)
        {
            var room = _context.Rooms.Find(id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
            return room;
        }
    }
}
