using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CadvancedOpdracht.Data;
using CadvancedOpdracht.Models;
using CadvancedOpdracht.Models.Dto;
using AutoMapper;

namespace CadvancedOpdracht.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly CadvancedOpdrachtContext _context;
        private readonly IMapper _dtoMapper;

        public LocationsController(CadvancedOpdrachtContext context, IMapper mapper)
        {
            _context = context;
            _dtoMapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var locations = _context.Locations
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .ToList();
            var locationVar = _dtoMapper.Map<List<LocationDto>>(locations);
            return Ok(locationVar);

        }

        // GET: api/Locations
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Location>>> GetLocations()
        //{
        //    var locations = _context.Locations.Include(l => l.Images).Include(l => l.Landlord).ToList();
        //    var locationVar = _dtoMapper.Map<List<Location>>(locations);
        //    return Ok(locationVar);
        //}
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var locations = await _context.Locations.ToListAsync();
            return Ok(locations);
        }
        // GET: api/Locations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id)
        {
            var location = await _context.Locations.FindAsync(id);

            if (location == null)
            {
                return NotFound();
            }

            return location;
        }

        // PUT: api/Locations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation(int id, Location location)
        {
            if (id != location.Id)
            {
                return BadRequest();
            }

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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

        // POST: api/Locations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocation", new { id = location.Id }, location);
        }

        // DELETE: api/Locations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            var location = await _context.Locations.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }

            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocationExists(int id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }
    }
}
