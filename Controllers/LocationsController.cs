using Asp.Versioning;
using CadvancedOpdracht.Dtos.Dto;
using CadvancedOpdracht.Models;
using CadvancedOpdracht.Services.Search;
using Microsoft.AspNetCore.Mvc;

namespace CadvancedOpdracht.Controllers
{
    [ApiVersion(1.0)]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly SearchService _searchService;

        public LocationsController(SearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetLocationsStandardAsync(cancellationToken);
            return Ok(locations);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetAllLocationsAsync(cancellationToken);
            return Ok(locations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id, CancellationToken cancellationToken)
        {
            try
            {
                var location = await _searchService.GetLocationByIdAsync(id, cancellationToken);
                return Ok(location);
            }
            catch (ApplicationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location, CancellationToken cancellationToken)
        {
            var createdLocation = await _searchService.AddLocationAsync(location, cancellationToken);
            return CreatedAtAction("GetLocation", new { id = createdLocation.Id }, createdLocation);
        }

        [HttpPost("Search")]
        public async Task<IActionResult> Search([FromBody] LocationSearchDto searchDto, CancellationToken cancellationToken)
        {
            var locations = await _searchService.SearchLocationsAsync(searchDto, cancellationToken);
            return Ok(locations);
        }

        [HttpGet("GetMaxPrice")]
        public async Task<IActionResult> GetMaxPrice(CancellationToken cancellationToken)
        {
            var maxPriceDto = await _searchService.GetMaxPriceAsync(cancellationToken);
            return Ok(maxPriceDto);
        }


        [HttpGet("GetDetails/{id}")]
        public async Task<IActionResult> GetDetails(int id, CancellationToken cancellationToken)
        {
            try
            {
                var locationDetails = await _searchService.GetLocationDetailsAsync(id, cancellationToken);
                return Ok(locationDetails);
            }
            catch (ApplicationException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("UnAvailableDates/{id}")]
        public async Task<IActionResult> GetUnavailableDates(int id, CancellationToken cancellationToken)
        {
            try
            {
                var UnAvDto = await _searchService.GetUnavailableDatesAsync(id, cancellationToken);
                return Ok(UnAvDto);
            }
            catch (ApplicationException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
