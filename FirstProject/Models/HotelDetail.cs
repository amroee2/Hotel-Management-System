using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.DAL
{
    public class HotelDetail
    {
        [Key]
        public int HotelDetailID { get; set; }
        [Required]
        public string ?HotelImage{ get; set; }

        public string ? Name { get; set; }
        //Relationships

        public int HotelID { get; set; }
        [ForeignKey("HotelRef")]
        public Hotel ?Hotel { get; set; }
    }
}
