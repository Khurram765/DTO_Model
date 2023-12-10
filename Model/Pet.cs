using System.ComponentModel.DataAnnotations;

namespace DTO_Model.Model
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        [Required]
        public int? BreedId { get; set; }
        [Required]
        public int? Age { get; set; }
        [Required]
        public int? LocationId { get; set; }
        [Required]
        public string? Description { get; set; }

        public Category category { get; set; }
        public Breed breed { get; set; }
        public Location location { get; set; }
    }
}
