using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.DAL
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        public string? RoomNumber { get; set; }
        [Required]
        public string? RoomName { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public int? Price { get; set; }
        [Required]
        public Boolean? Status { get; set; }
        [Required]
        public string? RoomImage { get; set; }
        public int HotelID { get; set; }
        [ForeignKey("HotelRef")]
        public Hotel ?Hotel {  get; set; }
    }
}
