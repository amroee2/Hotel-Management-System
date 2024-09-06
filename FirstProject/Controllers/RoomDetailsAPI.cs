using FirstProject.DAL;
using FirstProject.DsConn;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomDetailsAPI : ControllerBase
    {
        private readonly FirstContext _Conn;

        public RoomDetailsAPI(FirstContext Conn)
        {
            _Conn = Conn;
        }

        [HttpGet]
        [Route("getRoomDetails/{roomId}")]
        public IActionResult getRoomDetails(int roomId)
        {
            var roomDetails = _Conn.RoomDetails.Where(r => r.RoomId == roomId).ToList();
            if (roomDetails == null)
            {
                return BadRequest("There are currently no room details");
            }
            return Ok(roomDetails);
        }

        [HttpGet]
        [Route("insertRoomDetails/{roomId}/{name}/{count}")]
        public IActionResult insertRoomDetails(int roomId, string name, int count)
        {
            var room = _Conn.Rooms.FirstOrDefault(g => g.RoomId == roomId);

            if (room == null)
            {
                return BadRequest("no Room");
            }
            else
            {
                RoomDetail roomDetail = new RoomDetail();
                roomDetail.RoomId = room.RoomId;
                roomDetail.RoomDetailName = name;
                roomDetail.RoomDetailCount = count;

                _Conn.Add(roomDetail);
                _Conn.SaveChanges();

                return Ok("Room Details is added successfully");
            }
        }

        [HttpGet]
        [Route("updateRoomDetails/{roomDetailsId}/{name}/{count}")]
        public String updateRoomDetails(int roomDetailsId, String name, int count)
        {
            var roomDetails = _Conn.RoomDetails.FirstOrDefault(h => h.RoomDetailId == roomDetailsId);
            if (roomDetails == null)
            {
                return "no Room details to update";
            }
            else
            {
                roomDetails.RoomDetailName = name;
                roomDetails.RoomDetailCount = count;
                _Conn.SaveChanges();

                return "Update is Done";
            }
        }
    }
}
