using AutoMapper;
using DTO_Model.Model.DTO;

namespace DTO_Model.Model.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CategoryDTO, Category>().ReverseMap();
            CreateMap<BreedDTO, Breed>().ReverseMap();
            CreateMap<LocationDTO, Location>().ReverseMap();
            CreateMap<PetDTO,Pet>().ReverseMap();
        }
    }
}
