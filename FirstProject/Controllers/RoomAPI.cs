using FirstProject.DAL;
using FirstProject.DsConn;
using Microsoft.AspNetCore.Http;
using Nancy.Json;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomAPI : ControllerBase
    {
        //DB context
        private readonly FirstContext _Conn;

        //controller
        public RoomAPI(FirstContext conn)
        {
            _Conn = conn;
        }

        //Add Room
        [HttpGet]
        [Route("insertRoom/{Name}/{RoomN}/{Type}/{Price}/{Status}/{Image}")]
        public IActionResult AddRoom(string Name, string RoomN, string Type, string Price,bool Status, string Image)
        {
            
            int hotelId = 1;

            // Check if the hotel exists
            var hotel = _Conn.Hotels.FirstOrDefault(h => h.HotelId == hotelId);
            if (hotel == null)
            {
                return NotFound("Hotel not found.");
            }
            Room ObjRoom = new Room();
            ObjRoom.RoomName = Name;
            ObjRoom.RoomNumber = RoomN;
            ObjRoom.Type = Type;
            ObjRoom.Price = int.Parse(Price);
            ObjRoom.Status = Status;
            ObjRoom.RoomImage = Image; 
            ObjRoom.HotelID = hotelId; 

            // Add the room to the database
            _Conn.Rooms.Add(ObjRoom);
            _Conn.SaveChanges();

            return Ok("Room added successfully");
        }
            
        [HttpGet]
        [Route("UpdateRoom/{Name}/{RoomN}/{Type}/{Price}/{Status}/{Image}")]
        public string UpdateRoom(string Name, string RoomN, string Type, string Price, bool Status, string Image)
        {

            var ObjRoom = _Conn.Rooms.FirstOrDefault(r => r.RoomNumber == RoomN);

            if (ObjRoom == null)
            {
                return "Hotel not found";
            }
 
            // Update the hotel's properties
            ObjRoom.RoomName = Name;
            ObjRoom.RoomNumber = RoomN;
            ObjRoom.Type = Type;
            ObjRoom.Price = int.Parse(Price);
            ObjRoom.Status = Status;
            ObjRoom.RoomImage = Image;

            // Save changes to the database
            _Conn.SaveChanges();

            return "Room updated successfully";
        }

        //Delete Room
        [HttpDelete]
        [Route("DeleteRoom/{roomNumber}")]
        public IActionResult DeleteRoom(string roomNumber)
        {
            // Find the room by Room Number
            var room = _Conn.Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (room == null)
            {
                return NotFound("Room not found");
            }

            // Remove the room from the database
            _Conn.Rooms.Remove(room);
            _Conn.SaveChanges();

            return Ok("Room deleted successfully");
        }

        [HttpGet]
        [Route("CheckRoomStatus/{roomNumber}")]
        public IActionResult CheckRoomStatus(string roomNumber)
        {
            // Find the room by Room Number
            var room = _Conn.Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (room == null)
            {
                return NotFound("Room not found");
            }

            // Check the room's availability status
            if (room.Status == true ) 
            {
                return Ok("The room is currently reserved.");
            }
            else
            {
                return Ok("The room is available for reservation.");
            }
        }

        //Get all rooms 
        [HttpGet]
        [Route("GetRooms")]

        public IActionResult GetRooms()
        {
            var rooms = _Conn.Rooms.ToList();
            return rooms.Any() ? Ok(rooms) : BadRequest("There are currently no rooms available");
        }

        // Retrieve all rooms where Status is true (reserved)
        [HttpGet]
        [Route("ReservedRooms")]
        public IActionResult GetReservedRooms()
        {
            bool status = true;
            
            var reservedRooms = _Conn.Rooms.Where(r => r.Status == status).ToList();

            if (!reservedRooms.Any())
            {
                return NotFound("No reserved rooms found.");
            }

            return Ok(reservedRooms);
        }

        // Retrieve all rooms where Status is false (available)
        [HttpGet]
        [Route("AvailableRooms")]
        public IActionResult GetAvailableRooms()
        {
            bool status = false;

            var availableRooms = _Conn.Rooms.Where(r => r.Status == status).ToList();

            if (!availableRooms.Any())
            {
                return NotFound("No available rooms found.");
            }

            return Ok(availableRooms);
        }

    }
}