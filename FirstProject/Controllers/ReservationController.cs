using FirstProject.DAL;
using FirstProject.DsConn;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly FirstContext _Conn;

        public ReservationController(FirstContext conn)
        {
            _Conn = conn;
        }
        [HttpGet]
        [Route("createReservation/{StartDate}/{EndDate}/{Amount}/{GuestID}/{RoomID}")]
        public IActionResult CreateReservation(DateTimeOffset StartDate, DateTimeOffset EndDate, int Amount, int GuestID, int RoomID)
        {
            var reservation = _Conn.Reservations.FirstOrDefault(g => g.GuestID == GuestID && g.RoomId == RoomID);

            var room = _Conn.Rooms.FirstOrDefault(g => g.RoomId == RoomID);

            var guest = _Conn.Guests.FirstOrDefault(g => g.GuestId == GuestID);

            if (room == null)
            {
                return BadRequest("There is no such room in the system");
            }
            else if (room.Status == true)
            {
                return BadRequest("This room was already booked");
            }
            else if (reservation != null)
            {
                return BadRequest("User already reserved this room");
            }
            else
            {
                room.Status = true;
                Reservation reservation1 = new Reservation();
                reservation1.StartDate = StartDate;
                reservation1.EndDate = EndDate;
                reservation1.ReservationStatus = true;
                reservation1.RoomId = RoomID;
                reservation1.GuestID = GuestID;
                reservation1.TotalAmount = Amount;
                _Conn.Reservations.Add(reservation1 );
                _Conn.SaveChanges();
                return Ok(new
                {
                    reservation1.ReservationId,
                    reservation1.StartDate,
                    reservation1.EndDate,
                    reservation1.ReservationStatus,
                    reservation1.RoomId,
                    reservation1.GuestID,
                    reservation1.TotalAmount
                });
            }
        }
        [HttpGet]
        [Route("getReservations/{GuestID}")]
        public IActionResult getReservations(int GuestID)
        {
            var reservations = _Conn.Reservations.Where(g => g.GuestID == GuestID).ToList();
            if (reservations.Count > 0)
            {
                return Ok(reservations);
            }
            else
            {
                return BadRequest("User does not have any reservations");
            }
        }
        [HttpGet]
        [Route("cancelReservation/{ReservationID}")]
        public IActionResult cancelReservation(int ReservationID)
        {
            var reservation = _Conn.Reservations.FirstOrDefault(g => g.ReservationId == ReservationID);
            var room = _Conn.Rooms.FirstOrDefault(g => g.RoomId == reservation.RoomId);
            if (reservation != null)
            {
                room.Status = false;
                _Conn.Reservations.Remove(reservation);
                _Conn.SaveChanges();
                return Ok("Reservation was successfully canceled");
            }
            else
            {
                return BadRequest("Reservation does not exist");
            }
        }
    }
}
