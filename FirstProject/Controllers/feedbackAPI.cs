using FirstProject.DAL;
using FirstProject.DsConn;
using FirstProject.Migrations;
using FirstProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class feedbackAPI : ControllerBase
    {

        //DB context
        private readonly FirstContext _Conn;

        //controller
        public feedbackAPI(FirstContext conn)
        {
            _Conn = conn;
        }


        [HttpGet]
        [Route("insertFeedBack/{comment}/{GuestID}")]
        public IActionResult CreatFeedBack( String comment,int GuestID)
        {
            var guest = _Conn.Guests.FirstOrDefault(g => g.GuestId == GuestID);
            if (guest == null)
            {
                return BadRequest("There is no such guest in the system");
            }
           
            else
            {
                Feedback feedback = new Feedback();
                feedback.GuestID = GuestID;
                feedback.ReviewDate = DateTime.Now;
                feedback.Comments = comment;
                _Conn.Feedbacks.Add(feedback);
               _Conn.SaveChanges();
            }

            return Ok("feedback added successfuly");
        }

        //Update
        [HttpGet]
        [Route("Updatefeedback/{id}/{comment}")]
        public string UpdateFeedback(int id, String comment)
        {
            // Find the existing hotel by ID
            var ObjFeedback = _Conn.Feedbacks.FirstOrDefault(h => h.ReviewID == id);

            if (ObjFeedback == null)
            {
                return "Hotel not found";
            }

            ObjFeedback.Comments = comment;
            // Save changes to the database
            _Conn.SaveChanges();

            return "feedback updated successfully";
        }
    }
}
