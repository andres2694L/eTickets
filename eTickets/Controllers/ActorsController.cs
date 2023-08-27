using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext dbContext;

        public ActorsController(AppDbContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            var data = dbContext.Actors.ToList(); 
            return View(data);
        }
    }
}
