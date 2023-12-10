using System.ComponentModel.DataAnnotations;

namespace DTO_Model.Model
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string LocationName { get; set; }

        public List<Pet> pet { get; set; }
    }
}
