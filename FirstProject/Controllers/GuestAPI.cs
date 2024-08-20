using BCrypt.Net;
using FirstProject.DAL;
using FirstProject.DsConn;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestAPI : ControllerBase
    {

        //DB context
        private readonly FirstContext _Conn;
        
        //controller
        public GuestAPI(FirstContext conn)
        {
            _Conn = conn;
        }

        [HttpGet]
        [Route("login/{email}/{password}")]
        public IActionResult Login(string email, string password)
        {
            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            var guest = _Conn.Guests.FirstOrDefault(g => g.GuestEmail == email);

            if (guest != null && BCrypt.Net.BCrypt.Verify(password, guest.GuestPassword))
            {
                return Ok(new
                {
                    guest.GuestId,
                    guest.GuestEmail,
                    guest.GuestUserName
                });
            }
            else
            {
                return BadRequest("Invalid email or password");
            }
        }
        [HttpGet]
        [Route("register/{username}/{email}/{password}")]
        public IActionResult register(string username, string email, string password)
        {
            var guest = _Conn.Guests.FirstOrDefault(g => g.GuestEmail == email);

            if (guest != null)
            {
                return BadRequest($"{email} was already registered.");
            }
            else
            {
                Guest newGuest = new Guest();
                newGuest.GuestEmail = email;
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                newGuest.GuestPassword = hashedPassword;
                newGuest.GuestUserName = username;
                _Conn.Guests.Add(newGuest);
                _Conn.SaveChanges();
                return Ok(newGuest);
            }
        }
    }
}
