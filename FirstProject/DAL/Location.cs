using System.ComponentModel.DataAnnotations;

namespace FirstProject.DAL
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [Required]
        public string ?City { get; set; }
        [Required]
        public string ?State { get; set; }
        [Required]
        public string ?Country { get; set; }

        //Relationships
        public IList<Hotel>? Hotels { get; set; }
    }
}
