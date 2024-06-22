using CadvancedOpdracht.Dtos.Dto;
using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Repositories
{
    public interface IFullRepository
    {
        Task<List<Location>> GetAllLocationsAsync(CancellationToken cancellationToken);
        Task<List<Location>> GetLocationsWithDetailsAsync(CancellationToken cancellationToken);
        Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken);
        Task AddLocationAsync(Location location, CancellationToken cancellationToken);
        Task<float> GetMaxPriceAsync(CancellationToken cancellationToken);
        Task<List<Landlord>> GetAllLandlordsAsync(CancellationToken cancellationToken);
        bool LocationExists(int id);
        Task<List<Location>> SearchLocationsAsync(LocationSearchDto searchDto, CancellationToken cancellationToken);
    }
}
