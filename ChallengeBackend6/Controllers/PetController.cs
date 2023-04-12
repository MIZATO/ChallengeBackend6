using AutoMapper;
using ChallengeBackend6.Data;
using ChallengeBackend6.Data.Dtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChallengeBackend6.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private AluraPetContext _context;
        private IMapper _mapper;

        public PetController(AluraPetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PetController>
        [HttpGet]
        public IEnumerable<ReadPetDto> RecuperaPets([FromQuery] int skip = 0,
            [FromQuery] int take = 10)
        {
          return _mapper.Map<List<ReadPetDto>>(_context.Pets.Skip(skip).Take(take)
              .ToList());
        }

        // GET api/<PetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
