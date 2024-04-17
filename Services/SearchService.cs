using CadvancedOpdracht.Data;
using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Services
{
    public class SearchService
    {
        private readonly CadvancedOpdrachtContext _context;
        public SearchService(CadvancedOpdrachtContext context) { _context = context; }
        public IEnumerable<Location> GetAllLocations()
        {
            return _context.Location; 
        }

        public Location GetSpecificLocation(int locationId)
        {
            Location location = _context.Location.FirstOrDefault(l => l.Id == locationId);
            if (location == null)
            {
                throw new ApplicationException("Location not found for the given ID.");
            }
            return location;
            
        }
    }
}
