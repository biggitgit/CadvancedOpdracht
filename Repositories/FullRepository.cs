using CadvancedOpdracht.Data;
using CadvancedOpdracht.Dtos.Dto;
using CadvancedOpdracht.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Location>> SearchLocationsAsync(LocationSearchDto sDto, CancellationToken cancellationToken)
        {
            var searchData = _context.Locations.AsQueryable();

            if (sDto.Features.HasValue)
            {
                searchData = searchData.Where(l => (int)l.Features == sDto.Features.Value);
            }

            if (sDto.Type.HasValue)
            {
                searchData = searchData.Where(l => (int)l.Type == sDto.Type.Value);
            }

            if (sDto.Rooms.HasValue)
            {
                searchData = searchData.Where(l => l.Rooms >= sDto.Rooms.Value);
            }

            if (sDto.MinPrice.HasValue)
            {
                searchData = searchData.Where(l => l.PricePerDay >= sDto.MinPrice.Value);
            }

            if (sDto.MaxPrice.HasValue)
            {
                searchData = searchData.Where(l => l.PricePerDay <= sDto.MaxPrice.Value);
            }

            return await searchData
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .ToListAsync(cancellationToken);
        }
        public async Task<List<DateTime>> GetUnavailableDatesAsync(int id, CancellationToken cancellationToken)
        {
            var reservations = await _context.Reservations
                .Where(r => r.LocationId == id)
                .Select(r => new { r.StartDate, r.EndDate })
                .ToListAsync(cancellationToken);

            var unavailableDates = new List<DateTime>();

            foreach (var reservation in reservations)
            {
                for (var date = reservation.StartDate; date <= reservation.EndDate; date = date.AddDays(1))
                {
                    unavailableDates.Add(date);
                }
            }
            return unavailableDates;
        }
        public async Task<Customer> GetCustomerAsync(string email, string firstName, string lastName, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Email == email, cancellationToken);
            if (customer == null)
            {
                customer = new Customer
                {
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName
                };
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync(cancellationToken);
            }
            return customer;
        }
        public async Task AddReservationAsync(Reservation reservation, CancellationToken cancellationToken)
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
