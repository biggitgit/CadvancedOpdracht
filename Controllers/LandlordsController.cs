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
        private readonly ISearchService _searchService;

        public LandlordsController(ISearchService searchService)
        {
            _searchService = searchService;
        }
    }
}
