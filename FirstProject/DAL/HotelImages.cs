using System.ComponentModel.DataAnnotations;

namespace FirstProject.DAL
{
    public class HotelImages
    {
        [Key]
        public int HotelImageId { get; set; }
        [Required]
        public string ?HotelImagePath{ get; set; }

        //Relationships

        public int HotelID { get; set; }
        public Hotel ?Hotel { get; set; }
    }
}
