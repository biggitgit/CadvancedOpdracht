using Asp.Versioning;
using CadvancedOpdracht.Models;
using CadvancedOpdracht.Services.Search;
using Microsoft.AspNetCore.Mvc;

namespace CadvancedOpdracht.Controllers
{
    [ApiVersion(1.0)]
    [Route("api/[controller]")]
    [ApiController]
    public class LandlordsController : ControllerBase
    {
        private readonly SearchService _searchService;

        public LandlordsController(SearchService searchService)
        {
            _searchService = searchService;
        }

        // GET: api/Landlords
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Landlord>>> GetLandlords(CancellationToken cancellationToken)
        {
            var landlords = await _searchService.GetLandlordsAsync(cancellationToken);
            return Ok(landlords);
        }
    }
}
