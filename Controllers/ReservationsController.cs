using CadvancedOpdracht.Data;
using CadvancedOpdracht.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadvancedOpdracht.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly CadvancedOpdrachtContext _context;

        public ReservationsController(CadvancedOpdrachtContext context)
        {
            _context = context;
        }

        // GET: api/Reservations
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations()
        {
            return await _context.Reservations.ToListAsync();
        }
    }
}
