using FirstProject.DAL;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.Models
{
    public class Feedback
    {
        [Key]
        [Column(TypeName ="int")]
        [Required]
        public int ReviewID {  get; set; }
        [Required]
        public int GuestID {  get; set; }
        [ForeignKey("GuestID")]
        public Guest? Guest { get; set; }

        //[Column(TypeName ="nvarchar")]
        //public string? GuestName { get; set; }
        //[Column(TypeName = "nvarchar")]
        //public string? GuestEmail { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required]
        public string? Comments { get; set; }

        public DateTimeOffset? ReviewDate { get; set; }



    }
}
