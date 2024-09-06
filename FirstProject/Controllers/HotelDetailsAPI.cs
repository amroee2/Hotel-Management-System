using FirstProject.DAL;
using FirstProject.DsConn;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelDetailsAPI : ControllerBase
    {
        private readonly FirstContext _Conn;

    public HotelDetailsAPI(FirstContext conn)
        {
            _Conn = conn;
        }

        [HttpGet]
        [Route("getHotelDetails")]
        public IActionResult getHotelDetails()
        {
            return Ok(_Conn.HotelDetails.ToList());
        }
        [HttpGet]
        [Route("insertHotelDetails/{hotelId}/{name}/{image}")]
        public IActionResult createHotelDetails(int hotelId,String name,String image) {

            var hotel = _Conn.Hotels.FirstOrDefault(g => g.HotelId == hotelId);
            if (hotel == null)
            {
                return BadRequest("no hotel");
            }
            else {
                HotelDetail hotelDetails = new HotelDetail()
                {
                    HotelID = hotelId,
                    Name= name,
                    HotelImage = image

                    
                };
                _Conn.Add(hotelDetails);
                _Conn.SaveChanges();



                return Ok("hotel Details is added Successfuly");
            }

        }

        [HttpGet]
        [Route("updateHotelDetails/{hotelDetailsId}/{name}/{image}")]
        public String UpdatetheHotelDetails(int hotelDetailsId, String name,String image)
        {
            var hotelDetails= _Conn.HotelDetails.FirstOrDefault(h => h.HotelDetailID == hotelDetailsId);


            if (hotelDetails == null)
            {
                return "Hotel not found";
            }

            hotelDetails.Name = name;
            hotelDetails.HotelImage = image;

            // Save changes to the database
            _Conn.SaveChanges();

            return "Hotale Details updated successfully";
        }


    }
}
