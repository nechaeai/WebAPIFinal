using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIFinal.Models; // Assuming FavoriteMovie class is in the Models folder
using WebAPIFinal.Data; // Assuming ApplicationDbContext class is in the Data folder
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic; // For IEnumerable

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteMovieController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavoriteMovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FavoriteMovie
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteMovie>>> GetFavoriteMovie()
        {
            return await _context.FavoriteMovie.ToListAsync();
        }

        // GET: api/FavoriteMovie/1
        [HttpGet("{id}")]
        public async Task<ActionResult<FavoriteMovie>> GetFavoriteMovie(int id)
        {
            var favoriteMovie = await _context.FavoriteMovie.FindAsync(id);

            if (favoriteMovie == null)
            {
                return NotFound();
            }

            return favoriteMovie;
        }

        // PUT: api/FavoriteMovie/1
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoriteMovie(int id, FavoriteMovie favoriteMovie)
        {
            if (id != favoriteMovie.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoriteMovie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoriteMovieExists(id))
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

        // POST: api/FavoriteMovie
        [HttpPost]
        public async Task<ActionResult<FavoriteMovie>> PostFavoriteMovie(FavoriteMovie favoriteMovie)
        {
            _context.FavoriteMovie.Add(favoriteMovie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavoriteMovie", new { id = favoriteMovie.Id }, favoriteMovie);
        }

        // DELETE: api/FavoriteMovie/1
        [HttpDelete("{id}")]
        public async Task<ActionResult<FavoriteMovie>> DeleteFavoriteMovie(int id)
        {
            var favoriteMovie = await _context.FavoriteMovie.FindAsync(id);
            if (favoriteMovie == null)
            {
                return NotFound();
            }

            _context.FavoriteMovie.Remove(favoriteMovie);
            await _context.SaveChangesAsync();

            return favoriteMovie;
        }

        private bool FavoriteMovieExists(int id)
        {
            return _context.FavoriteMovie.Any(e => e.Id == id);
        }
    }
}
