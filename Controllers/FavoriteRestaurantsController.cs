using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIFinal.Models; 
using WebAPIFinal.Data; 
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic; 

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteRestaurants>>> GetFavoriteRestaurants(int? id)
        {
            if (id == null || id == 0) 
            {
                return await  _context.FavoriteRestaurants.take(5).ToListAsync();
            }
            else
            {
                var FavoriteRestaurants = await _context.FavoriteRestaurants.findasync(id);

                if (FavoriteRestaurants == null)
                {
                    return NotFound();
                }
                return new[] { FavoriteRestaurants };
            }
        }

    }
}