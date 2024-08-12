using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.DAL
{
    public class Reservation
    {
        [Key]

        public int ReservationId { get; set; }
        [Required]
        public DateTimeOffset? StartDate { get; set; }
        [Required]
        public DateTimeOffset? EndDate { get; set; }
        [Required]
        public Boolean ReservationStatus { get; set; }
        [Required]
        public int? TotalAmount { get; set; }

        //Relationships
        public int GuestID { get; set; }

        [ForeignKey("GuestRef")]

        public Guest? Guest { get; set; }

        public int RoomId {  get; set; }
        [ForeignKey("RoomRef")]

        public Room? Room { get; set; }

    }
}
