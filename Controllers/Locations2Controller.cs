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
        private bool LocationExists(int id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }
    }
}
