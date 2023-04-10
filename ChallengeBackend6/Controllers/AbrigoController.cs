using AutoMapper;
using ChallengeBackend6.Data.Dtos;
using ChallengeBackend6.Data;
using ChallengeBackend6.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeBackend6.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AbrigoController : Controller
    {
        private AluraPetContext _context;
        private IMapper _mapper;

        public AbrigoController(AluraPetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: /<AbrigoController>
        [HttpGet]
        public IEnumerable<ReadAbrigoDto> RecuperaAbrigos(
            [FromQuery] int skip = 0,
            [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadAbrigoDto>>(_context.Abrigos.Skip(skip).Take(take)
                .ToList());
        }

        // GET <AbrigoController>/5
        [HttpGet("{id}")]
        public IActionResult RecuperaAbrigosPorId(int id)
        {
            var abrigo = _context.Abrigos.FirstOrDefault(a => a.Id == id);
            if (abrigo == null) return NotFound();
            var abrigoDto = _mapper.Map<ReadAbrigoDto>(abrigo);
            return Ok(abrigo);
        }

        /// <summary>
        /// Adiciona um tutor ao banco de dados
        /// </summary>
        /// <param name="abrigoDto">Objeto com os campos necessarios para criacao de um tutor</param>
        /// <returns>IActionResult</returns>
        /// <response code="201"> Caso insercao seja feita com sucesso</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdicionaAbrigo([FromBody] CreateAbrigoDto abrigoDto)
        {
            Abrigo abrigo = _mapper.Map<Abrigo>(abrigoDto);

            _context.Abrigos.Add(abrigo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaAbrigosPorId),
                new { id = abrigo.Id }, abrigo);
        }

        // PUT api/<AbrigoController>/5
        [HttpPut("{id}")]
        public IActionResult AtualizaAbrigo(int id,
            [FromBody] UpdateAbrigoDto abrigoDto)
        {
            var abrigo = _context.Abrigos.FirstOrDefault(
                a => a.Id == id);
            if (abrigo == null) return NotFound();
            _mapper.Map(abrigoDto, abrigo);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/<AbrigoController>/5
        [HttpDelete("{id}")]
        public IActionResult DeletaAbrigo(int id)
        {
            var abrigo = _context.Abrigos.FirstOrDefault(
                a => a.Id == id);
            if (abrigo == null) return NotFound();
            _context.Remove(abrigo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
