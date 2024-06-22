using CadvancedOpdracht.Dtos.Dto;
using CadvancedOpdracht.Dtos.DtoV2;
using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Services
{
    public interface ISearchService
    {
        public Task<List<LocationDto>> GetLocationsStandardAsync(CancellationToken cancellationToken);
        Task<List<LocationDtoV2>> GetLocationsStandardV2Async(CancellationToken cancellationToken);
        public Task<List<Location>> GetAllLocationsAsync(CancellationToken cancellationToken); 
        Task<List<Location>> GetAllLocationsV2Async(CancellationToken cancellationToken);
        public Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken);
        public Task<Location> AddLocationAsync(Location location, CancellationToken cancellationToken);
        public Task<List<LocationDto>> SearchLocationsAsync(LocationSearchDto searchDto, CancellationToken cancellationToken);
        public Task<float> GetMaxPriceAsync(CancellationToken cancellationToken);
    }
}
