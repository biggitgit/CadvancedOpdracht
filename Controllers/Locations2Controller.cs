using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CadvancedOpdracht.Data;
using CadvancedOpdracht.Models;
using CadvancedOpdracht.Models.DtoV2;
using AutoMapper;
using Asp.Versioning;

namespace CadvancedOpdracht.Controllers
{
    [ApiVersion(2.0)]
    [Route("api/[controller]")]
    [ApiController]
    public class Locations2Controller : ControllerBase
    {
        private readonly CadvancedOpdrachtContext _context;
        private readonly IMapper _dtoMapper;

        public Locations2Controller(CadvancedOpdrachtContext context, IMapper mapper)
        {
            _context = context;
            _dtoMapper = mapper;
        }

        // GET: api/LocationsV2
        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var locations = await _context.Locations
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .ToListAsync(cancellationToken);
            var locationDtos = _dtoMapper.Map<List<LocationDtoV2>>(locations);
            return Ok(locationDtos);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var locations = await _context.Locations.ToListAsync(cancellationToken);
            return Ok(locations);
        }

        // GET: api/LocationsV2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id, CancellationToken cancellationToken)
        {
            var location = await _context.Locations.FindAsync(new object[] { id }, cancellationToken);

            if (location == null)
            {
                return NotFound();
            }

            return location;
        }

        // PUT: api/LocationsV2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation(int id, Location location, CancellationToken cancellationToken)
        {
            if (id != location.Id)
            {
                return BadRequest();
            }

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationExists(id))
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

        // POST: api/LocationsV2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location, CancellationToken cancellationToken)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync(cancellationToken);

            return CreatedAtAction("GetLocation", new { id = location.Id }, location);
        }

        // DELETE: api/LocationsV2/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLocation(int id)
        //{
        //    var location = await _context.Locations.FindAsync(id);
        //    if (location == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Locations.Remove(location);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool LocationExists(int id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }
    }
}
