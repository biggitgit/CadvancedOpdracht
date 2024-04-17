using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Services
{
    public interface ISearchService
    {
        public IEnumerable<Location> GetAllLocations();
        public Location GetSpecificLocation();
    }
}
