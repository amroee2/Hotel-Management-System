using System.ComponentModel.DataAnnotations;

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

        public Guest? Guest { get; set; }

        public int RoomId {  get; set; }

        public Room? Room { get; set; }

    }
}
