using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIFinal.Data;
using WebAPIFinal.Models;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpongeBobCharactersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SpongeBobCharactersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SpongeBobCharacters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpongeBobCharacter>>> GetSpongeBobCharacters(int? id)
        {
            if (id == null || id == 0)
            {
                return await _context.SpongeBobCharacter.Take(5).ToListAsync();
            }
            else
            {
                var spongeBobCharacter = await _context.SpongeBobCharacter.FindAsync(id);

                if (spongeBobCharacter == null)
                {
                    return NotFound();
                }

                return new[] { spongeBobCharacter };
            }
        }

        // POST: api/SpongeBobCharacters
        [HttpPost]
        public async Task<ActionResult<SpongeBobCharacter>> PostSpongeBobCharacter(SpongeBobCharacter spongeBobCharacter)
        {
            _context.SpongeBobCharacter.Add(spongeBobCharacter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpongeBobCharacters", new { id = spongeBobCharacter.Id }, spongeBobCharacter);
        }

        // PUT: api/SpongeBobCharacters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpongeBobCharacter(int id, SpongeBobCharacter spongeBobCharacter)
        {
            if (id != spongeBobCharacter.Id)
            {
                return BadRequest();
            }

            _context.Entry(spongeBobCharacter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpongeBobCharacterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/SpongeBobCharacters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SpongeBobCharacter>> DeleteSpongeBobCharacter(int id)
        {
            var spongeBobCharacter = await _context.SpongeBobCharacter.FindAsync(id);
            if (spongeBobCharacter == null)
            {
                return NotFound();
            }

            _context.SpongeBobCharacter.Remove(spongeBobCharacter);
            await _context.SaveChangesAsync();

            return spongeBobCharacter;
        }

        private bool SpongeBobCharacterExists(int id)
        {
            return _context.SpongeBobCharacter.Any(e => e.Id == id);
        }
    }
}
