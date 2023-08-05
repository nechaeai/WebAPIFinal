using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIFinal.Models; // Assuming TeamMember class is in the Models folder
using WebAPIFinal.Data; // Assuming ApplicationDbContext class is in the Data folder
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic; // For IEnumerable

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritePetController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavoritePetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FavoritePet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoritePet>>> GetFavoritePet()
        {
            return await _context.FavoritePet.ToListAsync();
        }

        // GET: api/FavoritePet/1
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<FavoritePet>>> GetFavoritePet(int? id)
        {
            if (id == null || id == 0)
            {
                return await _context.FavoritePet.Take(5).ToListAsync();
            }
            
            var favoritePet = await _context.FavoritePet.FindAsync(id);

            if (favoritePet == null)
            {
                return NotFound();
            }

            return new FavoritePet[] { favoritePet };
        }
        
        // PUT: api/FavoritePet/1
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoriteFood(int id, FavoritePet favoritePet)
        {
            if (id != favoritePet.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoritePet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoritePetExists(id))
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

        // POST: api/FavoritePet
        [HttpPost]
        public async Task<ActionResult<FavoritePet>> PostFavoritePet(FavoritePet favoritePet)
        {
            _context.FavoritePet.Add(favoritePet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavoritePet", new { id = favoritePet.Id }, favoritePet);
        }

        // DELETE: api/FavoritePet/1
        [HttpDelete("{id}")]
        public async Task<ActionResult<FavoritePet>> DeleteFavoritePet(int id)
        {
            var favoritePet = await _context.FavoritePet.FindAsync(id);
            if (favoritePet == null)
            {
                return NotFound();
            }

            _context.FavoritePet.Remove(favoritePet);
            await _context.SaveChangesAsync();

            return favoritePet;
        }
        
        private bool FavoritePetExists(int id)
        {
            return _context.FavoritePet.Any(e => e.Id == id);
        }
    }
}
