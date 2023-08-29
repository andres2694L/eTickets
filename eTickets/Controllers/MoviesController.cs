using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext dbContext;

        public MoviesController(AppDbContext context)
        {
            dbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await dbContext.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
