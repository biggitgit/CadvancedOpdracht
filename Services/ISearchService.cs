using CadvancedOpdracht.Models;
using CadvancedOpdracht.Models.Dto;

namespace CadvancedOpdracht.Services
{
    public interface ISearchService
    {
        public Task<List<LocationDto>> GetLocationsStandardAsync(CancellationToken cancellationToken);
        public Task<List<Location>> GetAllLocationsAsync(CancellationToken cancellationToken);
        public Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken);
        public Task<Location> AddLocationAsync(Location location, CancellationToken cancellationToken);
        public Task<List<LocationDto>> SearchLocationsAsync(LocationSearchDto searchDto, CancellationToken cancellationToken);
        public Task<float> GetMaxPriceAsync(CancellationToken cancellationToken);
        //public Task<LocationDetailsDto> GetLocationDetailsAsync(int id, CancellationToken cancellationToken);
    }
}
