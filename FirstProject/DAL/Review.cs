using System.ComponentModel.DataAnnotations;

namespace FirstProject.DAL
{
    public class Review
    {
        [Key] 
        public int? ReviewId { get; set; }

        [Required]
        public int? Rating { get; set; }
        [Required]
        public string? Comments { get; set; }

        public DateTimeOffset ReviewDate { get; set; }

        //Relationships
        public int GuestId { get; set; }

        public Guest ?Guest { get; set; }

        public int HotelId { get; set; }

        public Hotel ?Hotel { get; set; }
    }
}
