using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CadvancedOpdracht.Data;
using CadvancedOpdracht.Models;
using Asp.Versioning;
using System.Threading;
using CadvancedOpdracht.Services;

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
