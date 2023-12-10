using System.ComponentModel.DataAnnotations;

namespace DTO_Model.Model
{
    public class Breed
    {
        [Key]
        public int Id { get; set; }
        public string BreedName { get; set; }
        public int CategoryId { get; set; }

        public Category category { get; set; }
        public List<Pet> pet { get; set; }
    }
}
