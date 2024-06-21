using AutoMapper;
using CadvancedOpdracht.Data;
using CadvancedOpdracht.Models;
using CadvancedOpdracht.Models.Dto;
using CadvancedOpdracht.Models.DtoV2;
using Microsoft.EntityFrameworkCore;

namespace CadvancedOpdracht.Services
{
    public class SearchService : ISearchService
    {
        private readonly CadvancedOpdrachtContext _context;
        private readonly IMapper _dtoMapper;

        public SearchService(CadvancedOpdrachtContext context, IMapper mapper)
        {
            _context = context;
            _dtoMapper = mapper;
        }

        public async Task<List<LocationDto>> GetLocationsStandardAsync(CancellationToken cancellationToken)
        {
            var locations = await _context.Locations
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .ToListAsync(cancellationToken);
            return _dtoMapper.Map<List<LocationDto>>(locations);
        }
        public async Task<List<LocationDtoV2>> GetLocationsStandardV2Async(CancellationToken cancellationToken)
        {
            var locations = await _context.Locations
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .ToListAsync(cancellationToken);
            return _dtoMapper.Map<List<LocationDtoV2>>(locations);
        }

        public async Task<List<Location>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            return await _context.Locations.ToListAsync(cancellationToken);
        }
        public async Task<List<Location>> GetAllLocationsV2Async(CancellationToken cancellationToken)
        {
            return await _context.Locations.ToListAsync(cancellationToken);
        }

        public async Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            var location = await _context.Locations.FindAsync(new object[] { id }, cancellationToken);
            if (location == null)
            {
                throw new ApplicationException("Location not found for the given ID.");
            }
            return location;
        }

        public async Task<Location> AddLocationAsync(Location location, CancellationToken cancellationToken)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync(cancellationToken);
            return location;
        }

        public async Task<List<LocationDto>> SearchLocationsAsync(LocationSearchDto searchDto, CancellationToken cancellationToken)
        {
            var query = _context.Locations.AsQueryable();

            if (searchDto.Features.HasValue)
            {
                query = query.Where(l => (int)l.Features == searchDto.Features.Value);
            }

            if (searchDto.Type.HasValue)
            {
                query = query.Where(l => (int)l.Type == searchDto.Type.Value);
            }

            if (searchDto.Rooms.HasValue)
            {
                query = query.Where(l => l.Rooms >= searchDto.Rooms.Value);
            }

            if (searchDto.MinPrice.HasValue)
            {
                query = query.Where(l => l.PricePerDay >= searchDto.MinPrice.Value);
            }

            if (searchDto.MaxPrice.HasValue)
            {
                query = query.Where(l => l.PricePerDay <= searchDto.MaxPrice.Value);
            }

            var locations = await query
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .ToListAsync(cancellationToken);
            return _dtoMapper.Map<List<LocationDto>>(locations);
        }

        public async Task<float> GetMaxPriceAsync(CancellationToken cancellationToken)
        {
            return await _context.Locations.MaxAsync(l => l.PricePerDay, cancellationToken);
        }

        //public async Task<LocationDetailsDto> GetLocationDetailsAsync(int id, CancellationToken cancellationToken)
        //{
        //    var location = await _context.Locations
        //        .Include(l => l.Images)
        //        .Include(l => l.Landlord)
        //        .FirstOrDefaultAsync(l => l.Id == id, cancellationToken);

        //    if (location == null)
        //    {
        //        throw new ApplicationException("Location not found for the given ID.");
        //    }

        //    return _dtoMapper.Map<LocationDetailsDto>(location);
        //}

        public bool LocationExists(int id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }
    }
}
