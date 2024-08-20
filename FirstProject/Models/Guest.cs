using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.DAL
{
    public class Guest
    {
        [Key]
        [Column(TypeName = "int")]
        public int GuestId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string? GuestUserName { get; set; }
     
        
        [Required, EmailAddress]
        [Column(TypeName = "nvarchar(max)")]
        public string? GuestEmail { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string? GuestPassword { get; set; }
    }
}
