using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Repositories.LocationRepo
{
    public interface ILocationRepository
    {
        public Location Get(int id);
        public void Add(Location location);
        public void Update(Location location);
        public void Delete(int id);
    }
}
