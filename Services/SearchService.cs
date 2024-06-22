using AutoMapper;
using CadvancedOpdracht.Dtos.Dto;
using CadvancedOpdracht.Dtos.DtoV2;
using CadvancedOpdracht.Models;
using CadvancedOpdracht.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CadvancedOpdracht.Services
{
    public class SearchService : ISearchService
    {
        private readonly IFullRepository _repository;
        private readonly IMapper _dtoMapper;

        public SearchService(IFullRepository repository, IMapper mapper)
        {
            _repository = repository;
            _dtoMapper = mapper;
        }

        public async Task<List<LocationDto>> GetLocationsStandardAsync(CancellationToken cancellationToken)
        {
            var locations = await _repository.GetLocationsWithDetailsAsync(cancellationToken);
            return _dtoMapper.Map<List<LocationDto>>(locations);
        }

        public async Task<List<LocationDtoV2>> GetLocationsStandardV2Async(CancellationToken cancellationToken)
        {
            var locations = await _repository.GetLocationsWithDetailsAsync(cancellationToken);
            return _dtoMapper.Map<List<LocationDtoV2>>(locations);
        }

        public async Task<List<Location>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            return await _repository.GetAllLocationsAsync(cancellationToken);
        }

        public async Task<List<Location>> GetAllLocationsV2Async(CancellationToken cancellationToken)
        {
            return await _repository.GetAllLocationsAsync(cancellationToken);
        }

        public async Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            var location = await _repository.GetLocationByIdAsync(id, cancellationToken);
            if (location == null)
            {
                throw new ApplicationException("Location not found for the given ID.");
            }
            return location;
        }

        public async Task<Location> AddLocationAsync(Location location, CancellationToken cancellationToken)
        {
            await _repository.AddLocationAsync(location, cancellationToken);
            return location;
        }

        public async Task<List<LocationDto>> SearchLocationsAsync(LocationSearchDto searchDto, CancellationToken cancellationToken)
        {
            var locations = await _repository.SearchLocationsAsync(searchDto, cancellationToken);
            return _dtoMapper.Map<List<LocationDto>>(locations);
        }

        public async Task<float> GetMaxPriceAsync(CancellationToken cancellationToken)
        {
            return await _repository.GetMaxPriceAsync(cancellationToken);
        }

        public async Task<LocationDetailsDto> GetLocationDetailsAsync(int id, CancellationToken cancellationToken)
        {
            var location = await _repository.GetLocationByIdAsync(id, cancellationToken);
            if (location == null)
            {
                throw new ApplicationException("Location not found for the given ID.");
            }
            return _dtoMapper.Map<LocationDetailsDto>(location);
        }

        public bool LocationExists(int id)
        {
            return _repository.LocationExists(id);
        }

        public async Task<ActionResult<IEnumerable<Landlord>>> GetLandlordsAsync(CancellationToken cancellationToken)
        {
            return await _repository.GetAllLandlordsAsync(cancellationToken);
        }
    }
}
