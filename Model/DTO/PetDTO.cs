using System.ComponentModel.DataAnnotations;

namespace DTO_Model.Model.DTO
{
    public class PetDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public int? BreedId { get; set; }
        
        public int? Age { get; set; }
        
        public int? LocationId { get; set; }
        
        public string? Description { get; set; }
    }
}
