using System.ComponentModel.DataAnnotations;

namespace FirstProject.DAL
{
    public class Hotel
    {

        [Key]
        public int HotelId { get; set; }
        [Required]
        public string ?HotelName { get; set; }
        [Required]
        public string ?HotelDescription { get; set; }
        [Required]
        public string ?HotelPhoneNumber { get; set; }
        [Required, EmailAddress]
        public string ?HotelEmail { get; set; }
        [Required]
        public int ?HotelRating { get; set; }

        //Relationships
        public IList<Room>? Rooms { get; set; }
        public IList<HotelImages>? Images { get; set; }

        public IList<Review> ?Reviews { get; set; }

        public int LocationID { get; set; }

        public Location? Location { get; set; }

    }
}
