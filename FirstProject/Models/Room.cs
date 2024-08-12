using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.DAL
{
    public class Room
    {
        [Key]
        [Column(TypeName = "int")]

        public int RoomId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string? RoomNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string? RoomName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string? Type { get; set; }
        [Required]
        [Column(TypeName = "int")]

        public int? Price { get; set; }
        [Required]
        public Boolean? Status { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string? RoomImage { get; set; }
        [Column(TypeName = "int")]
        public int HotelID { get; set; }
        [ForeignKey("HotelID")]
        public Hotel ?Hotel {  get; set; }
    }
}
