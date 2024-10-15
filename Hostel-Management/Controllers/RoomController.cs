using Hostel_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hostel_Management.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoom _roomRepository;

        public RoomController(IRoom roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public IActionResult Index()
        {
            var rooms = _roomRepository.GetAllRooms();
            return View(rooms);
        }

        public IActionResult AvailableRooms()
        {
            var availableRooms = _roomRepository.GetAvailableRooms();
            return View(availableRooms);
        }

        public IActionResult Details(int id)
        {
            var room = _roomRepository.GetRoomById(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Room room)
        {
            if (ModelState.IsValid)
            {
                _roomRepository.AddRoom(room);
                return RedirectToAction("Index");
            }
            return View(room);
        }

        public IActionResult Edit(int id)
        {
            var room = _roomRepository.GetRoomById(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Room room)
        {
            if (ModelState.IsValid)
            {
                _roomRepository.UpdateRoom(room);
                return RedirectToAction("Index");
            }
            return View(room);
        }

        public IActionResult Delete(int id)
        {
            var room = _roomRepository.GetRoomById(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _roomRepository.DeleteRoom(id);
            return RedirectToAction("Index");
        }
    }
}
