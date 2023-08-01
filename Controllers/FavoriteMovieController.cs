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
    public class FavoriteMovieController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavoriteMovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FavoriteMovie
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteMovie>>> GetFavoriteMovie(int? id)
        {
            if (id == null || id == 0)
            {
                return await _context.FavoriteMovie.Take(5).ToListAsync();
            }
            else
            {
                var favoriteMovie = await _context.FavoriteMovie.FindAsync(id);

                if (favoriteMovie == null)
                {
                    return NotFound();
                }

                return new[] { favoriteMovie };
            }
        }
    }
}
