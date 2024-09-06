using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.DAL
{
    public class RoomDetail
    {
        [Key]
        [Column(TypeName = "int")]
        public int RoomDetailId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string? RoomDetailName { get; set; }
        [Column(TypeName = "int")]
        public int RoomDetailCount { get; set; }
        //Relationships
        [Column(TypeName = "int")]
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room? Room { get; set; }

    }
}
