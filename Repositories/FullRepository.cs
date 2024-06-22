using CadvancedOpdracht.Data;
using CadvancedOpdracht.Dtos.Dto;
using CadvancedOpdracht.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CadvancedOpdracht.Repositories
{
    public class FullRepository : IFullRepository
    {
        private readonly CadvancedOpdrachtContext _context;

        public FullRepository(CadvancedOpdrachtContext context)
        {
            _context = context;
        }

        public async Task<List<Location>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            return await _context.Locations.ToListAsync(cancellationToken);
        }

        public async Task<List<Location>> GetLocationsWithDetailsAsync(CancellationToken cancellationToken)
        {
            return await _context.Locations
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .ToListAsync(cancellationToken);
        }

        public async Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Locations
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .FirstOrDefaultAsync(l => l.Id == id, cancellationToken);
        }

        public async Task AddLocationAsync(Location location, CancellationToken cancellationToken)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<float> GetMaxPriceAsync(CancellationToken cancellationToken)
        {
            return await _context.Locations.MaxAsync(l => l.PricePerDay, cancellationToken);
        }

        public async Task<List<Landlord>> GetAllLandlordsAsync(CancellationToken cancellationToken)
        {
            return await _context.Landlords.ToListAsync(cancellationToken);
        }

        public bool LocationExists(int id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }

        public async Task<List<Location>> SearchLocationsAsync(LocationSearchDto searchDto, CancellationToken cancellationToken)
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

            return await query
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .ToListAsync(cancellationToken);
        }
    }
}
