using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.DAL
{
    public class RoomDetail
    {
        [Key]
        public int RoomDetailId { get; set; }
        [Required]
        public string? RoomDetailName { get; set; }

        public int RoomDetailCount { get; set; }
        //Relationships
        public int RoomId { get; set; }
        [ForeignKey("RoomRef")]
        public Room? Room { get; set; }

    }
}
