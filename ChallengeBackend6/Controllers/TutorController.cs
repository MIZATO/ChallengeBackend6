using Microsoft.AspNetCore.Mvc;
using ChallengeBackend6.Models;
using ChallengeBackend6.Data;
using AutoMapper;
using ChallengeBackend6.Data.Dtos;

namespace ChallengeBackend6.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TutorController : ControllerBase
    {
        private AluraPetContext _context;
        private IMapper _mapper;

        public TutorController(AluraPetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper; 
        }

        // GET: /<TutorController>
        [HttpGet]
        public IEnumerable<ReadTutorDto> RecuperaTutores(
            [FromQuery] int skip = 0,
            [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadTutorDto>>(_context.Tutores.Skip(skip).Take(take)
                .ToList());
        }

        // GET <TutorController>/5
        [HttpGet("{id}")]
        public IActionResult RecuperaTutoresPorId(int id)
        {
            var tutor = _context.Tutores.FirstOrDefault(t => t.Id == id);
            if (tutor == null) return NotFound();
            var tutorDto = _mapper.Map<ReadTutorDto>(tutor);
            return Ok(tutor);
        }

        /// <summary>
        /// Adiciona um tutor ao banco de dados
        /// </summary>
        /// <param name="tutorDto">Objeto com os campos necessarios para criacao de um tutor</param>
        /// <returns>IActionResult</returns>
        /// <response code="201"> Caso insercao seja feita com sucesso</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdicionaTutor([FromBody] CreateTutorDto tutorDto)
        {
            Tutor tutor = _mapper.Map<Tutor>(tutorDto);

            _context.Tutores.Add(tutor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaTutoresPorId),
                new {id  = tutor.Id}, tutor);
        }

        // PUT api/<TutorController>/5
        [HttpPut("{id}")]
        public IActionResult AtualizaTutor(int id,
            [FromBody] UpdateTutorDto tutorDto)
        {
            var tutor = _context.Tutores.FirstOrDefault(
                t => t.Id == id);
            if (tutor == null) return NotFound();
            _mapper.Map(tutorDto, tutor);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/<TutorController>/5
        [HttpDelete("{id}")]
        public IActionResult DeletaTutor(int id)
        {
            var tutor = _context.Tutores.FirstOrDefault(
                t => t.Id == id);
            if (tutor == null) return NotFound();
            _context.Remove(tutor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
