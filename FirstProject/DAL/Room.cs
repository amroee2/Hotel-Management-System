using System.ComponentModel.DataAnnotations;

namespace FirstProject.DAL
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        public string? RoomNumber { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public int? Price { get; set; }
        [Required]
        public Boolean? Status { get; set; }
        //Relationships
        public int HotelID { get; set; }
        public Hotel ?Hotel {  get; set; }
        public IList<RoomImages>? Images { get; set; }
    }
}
