using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.DAL
{
    public class Reservation
    {
        [Key]
        [Column(TypeName = "int")]

        public int ReservationId { get; set; }
        [Required]

        public DateTimeOffset? StartDate { get; set; }
        [Required]
        public DateTimeOffset? EndDate { get; set; }
        [Required]
        public Boolean ReservationStatus { get; set; }
        [Required]
        [Column(TypeName = "int")]

        public int? TotalAmount { get; set; }

        //Relationships
        [Column(TypeName = "int")]

        public int GuestID { get; set; }

        [ForeignKey("GuestID")]

        public Guest? Guest { get; set; }
        [Column(TypeName = "int")]

        public int RoomId {  get; set; }
        [ForeignKey("RoomId")]

        public Room? Room { get; set; }

    }
}
