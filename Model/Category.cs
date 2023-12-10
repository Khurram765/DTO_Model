using System.ComponentModel.DataAnnotations;

namespace DTO_Model.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? CategoryName { get; set; }

        public List<Breed> breed { get; set;}
        public List<Pet> pet { get; set; }
    }
}
