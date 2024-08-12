using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.DAL
{
    public class HotelDetail
    {
        [Key]
        [Column(TypeName = "int")]

        public int HotelDetailID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string ?HotelImage{ get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]

        public string ? Name { get; set; }
        //Relationships
        [Column(TypeName = "int")]

        public int HotelID { get; set; }
        [ForeignKey("HotelID")]
        public Hotel ?Hotel { get; set; }
    }
}
