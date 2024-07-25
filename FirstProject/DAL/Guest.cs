using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FirstProject.DAL
{
    public class Guest
    {
        [Key]

        public int GuestId { get; set; }
        [Required]
        public string? GuestFirstName { get; set; }
        [Required]
        public string? GuestLastName { get; set; }
        [Required]
        public string? GuestPhone { get; set; }
        [Required, EmailAddress]
        public string? GuestEmail { get; set; }
        [Required]
        public string? GuestAddess { get; set; }
        [Required]
        public string? GuestPassword { get; set; }

        //Relationships

        public DbSet<Reservation>? Reservations { get; set; }
        public DbSet<Review>? Reviews { get; set; }
    }
}
