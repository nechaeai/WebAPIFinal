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
        public async Task<ActionResult<IEnumerable<FavoritePet>>> GetFavoritePet(int? id)
        {
            if (id == null || id == 0)
            {
                return await _context.FavoritePet.Take(5).ToListAsync();
            }
            else
            {
                var favoritePet = await _context.FavoritePet.FindAsync(id);

                if (favoritePet == null)
                {
                    return NotFound();
                }

                return new[] { favoritePet };
            }
        }
    }
}
