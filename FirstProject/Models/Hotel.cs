using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.DAL
{
    public class Hotel
    {

        [Key]
        [Column(TypeName = "int")]
        public int HotelId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string ?HotelName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string ?HotelDescription { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string ?HotelPhoneNumber { get; set; }

        [Required, EmailAddress]
        [Column(TypeName = "nvarchar(max)")]

        public string ?HotelEmail { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string? HotelImage { get; set; }
    }
}
