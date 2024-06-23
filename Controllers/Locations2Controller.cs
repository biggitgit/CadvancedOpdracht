using Asp.Versioning;
using CadvancedOpdracht.Services.Search;
using Microsoft.AspNetCore.Mvc;

namespace CadvancedOpdracht.Controllers
{
    [ApiVersion(2.0)]
    [Route("api/[controller]")]
    [ApiController]
    public class Locations2Controller : ControllerBase
    {
        private readonly ISearchService _searchService;

        public Locations2Controller(ISearchService searchService)
        {
            _searchService = searchService;
        }

        // GET: api/LocationsV2
        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetLocationsStandardV2Async(cancellationToken);
            return Ok(locations);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetAllLocationsAsync(cancellationToken);
            return Ok(locations);
        }
    }
}
