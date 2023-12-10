using System.ComponentModel.DataAnnotations;

namespace DTO_Model.Model.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        
        public string? CategoryName { get; set; }

        //public List<Breed> breed { get; set; }
        //public List<Pet> pet { get; set; }
    }
}
