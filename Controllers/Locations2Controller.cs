using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CadvancedOpdracht.Data;
using CadvancedOpdracht.Models;
using AutoMapper;
using Asp.Versioning;
using CadvancedOpdracht.Services;

namespace CadvancedOpdracht.Controllers
{
    [ApiVersion(2.0)]
    [Route("api/[controller]")]
    [ApiController]
    public class Locations2Controller : ControllerBase
    {
        private readonly SearchService _searchService;

        public Locations2Controller(SearchService searchService)
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
