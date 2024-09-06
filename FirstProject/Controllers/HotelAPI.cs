using FirstProject.DAL;
using FirstProject.DsConn;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelAPI : ControllerBase
    {

        //DB context
        private readonly FirstContext _Conn;

        //controller
        public HotelAPI(FirstContext conn)
        {
            _Conn = conn;
        }
        [HttpGet]
        [Route("getHotel")]
        public IActionResult GetHotel()
        {
            var hotel = _Conn.Hotels;
            return Ok(hotel);
        }
        [HttpGet]
        [Route("insertHotel/{Name}/{Desc}/{PhoneN}/{Email}/{Image}")]
        public string AddHotel(string Name,string Desc,string PhoneN,string Email,string Image)
        {
            Hotel ObjHotel= new Hotel();
            ObjHotel.HotelName = Name;
            ObjHotel.HotelDescription = Desc;
            ObjHotel.HotelPhoneNumber = PhoneN;
            ObjHotel.HotelEmail = Email;
            ObjHotel.HotelImage = Image;
            _Conn.Hotels.Add(ObjHotel);
            _Conn.SaveChanges();

            return "";
        }

        //Update
        [HttpGet]
        [Route("UpdateHotel/{id}/{Name}/{Desc}/{PhoneN}/{Email}/{Image}")]
        public string UpdateHotel(int id, string Name, string Desc, string PhoneN, string Email, string Image)
        {
            // Find the existing hotel by ID
            var ObjHotel = _Conn.Hotels.FirstOrDefault(h => h.HotelId == id);

            if (ObjHotel == null)
            {
                return "Hotel not found";
            }

            // Update the hotel's properties
            ObjHotel.HotelName = Name;
            ObjHotel.HotelDescription = Desc;
            ObjHotel.HotelPhoneNumber = PhoneN;
            ObjHotel.HotelEmail = Email;
            ObjHotel.HotelImage = Image;

            // Save changes to the database
            _Conn.SaveChanges();

            return "Hotel updated successfully";
        }

    }
}