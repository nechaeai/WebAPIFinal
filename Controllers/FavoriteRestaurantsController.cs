using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIFinal.Models; // Assuming FavoriteRestaurants class is in the Models folder
using WebAPIFinal.Data; // Assuming ApplicationDbContext class is in the Data folder
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic; // For IEnumerable

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteRestaurantsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavoriteRestaurantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FavoriteRestaurants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteRestaurants>>> GetFavoriteRestaurants()
        {
            return await _context.FavoriteRestaurants.ToListAsync();
        }

        // GET: api/FavoriteRestaurants/1
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<FavoriteRestaurants>>> GetFavoriteRestaurants(int? id)
        {
            if (id == null || id == 0)
            {
                return await _context.FavoriteRestaurants.Take(5).ToListAsync();
            }

            var favoriteRestaurant = await _context.FavoriteRestaurants.FindAsync(id);

            if (favoriteRestaurant == null)
            {
                return NotFound();
            }

            return new FavoriteRestaurants[] { favoriteRestaurant };
        }
        // PUT: api/FavoriteRestaurants/1
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoriteRestaurants(int id, FavoriteRestaurants favoriteRestaurant)
        {
            if (id != favoriteRestaurant.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoriteRestaurant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoriteRestaurantsExists(id))
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

        // POST: api/FavoriteRestaurants
        [HttpPost]
        public async Task<ActionResult<FavoriteRestaurants>> PostFavoriteRestaurants(FavoriteRestaurants favoriteRestaurant)
        {
            _context.FavoriteRestaurants.Add(favoriteRestaurant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavoriteRestaurants", new { id = favoriteRestaurant.Id }, favoriteRestaurant);
        }

        // DELETE: api/FavoriteRestaurants/1
        [HttpDelete("{id}")]
        public async Task<ActionResult<FavoriteRestaurants>> DeleteFavoriteRestaurants(int id)
        {
            var favoriteRestaurant = await _context.FavoriteRestaurants.FindAsync(id);
            if (favoriteRestaurant == null)
            {
                return NotFound();
            }

            _context.FavoriteRestaurants.Remove(favoriteRestaurant);
            await _context.SaveChangesAsync();

            return favoriteRestaurant;
        }

        private bool FavoriteRestaurantsExists(int id)
        {
            return _context.FavoriteRestaurants.Any(e => e.Id == id);
        }
    }
}