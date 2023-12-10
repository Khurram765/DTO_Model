using AutoMapper;
using DTO_Model.Model;
using DTO_Model.Model.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DTO_Model.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BreedController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BreedController(ApplicationDbContext context,IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetBreed()
        {
            var data = await this._context.breeds.Include(b => b.category).ToListAsync();
            return Ok(data);
        //    var breeds = await _context.breeds
        //.Include(b => b.category)
        //.ToListAsync();

        //    var breedDtos = _mapper.Map<List<BreedDTO>>(breeds); 

        //    return new JsonResult(breedDtos);
        }
        [HttpPost]
        public async Task<IActionResult> SetBreed(BreedDTO breed)
        {
            var newBreed = _mapper.Map<Breed>(breed);
            var data = _context.breeds.Add(newBreed);
            this._context.SaveChanges();
            return Ok();
        }
        [HttpGet]
        [Route("/Pet")]
        public async Task<IActionResult> GetPet()
        {
            var data = await this._context.pet.Include(b => b.category).ThenInclude(c=>c.breed).ToListAsync();
            return Ok(data);
        }
    }
}
