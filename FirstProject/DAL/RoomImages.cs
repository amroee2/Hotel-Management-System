using System.ComponentModel.DataAnnotations;

namespace FirstProject.DAL
{
    public class RoomImages
    {
        [Key]
        public int RoomImageId { get; set; }
        [Required]
        public string? RoomImagePath { get; set; }
        //Relationships
        public int RoomId { get; set; }
        public Room? Room { get; set; }

    }
}
