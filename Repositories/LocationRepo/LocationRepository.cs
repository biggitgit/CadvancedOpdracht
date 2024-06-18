//using CadvancedOpdracht.Data;
//using CadvancedOpdracht.Models;

//namespace CadvancedOpdracht.Repositories.LocationRepo
//{
//    public class LocationRepository : ILocationRepository
//    {
//        private readonly CadvancedOpdrachtContext _context;

//        public LocationRepository(CadvancedOpdrachtContext context)
//        {
//            _context = context;
//        }
//        public void Add(Location location)
//        {
//            if (location == null)
//            {
//                throw new ArgumentNullException(nameof(location));
//            }
//            _context.Location.Add(location);
//            _context.SaveChanges();
//        }

//        public void Delete(int id)
//        {
//            var location = _context.Location.Find(id);
//            if (location == null)
//                throw new InvalidOperationException($"Location with id {id} not found.");

//            _context.Location.Remove(location);
//            _context.SaveChanges();
//        }
//        public IEnumerable<Location> GetAll()
//        {
//            return _context.Location.ToList();
//        }
//        public Location Get(int id)
//        {
//            return _context.Location.Find(id);
//        }

//        public void Update(Location location)
//        {
//            if (location == null)
//            {
//                throw new ArgumentNullException(nameof(location));
//            }

//            var existingLocation = _context.Location.Find(location.Id);
//            if (existingLocation == null)
//            {
//                throw new InvalidOperationException($"Location with id {location.Id} not found.");
//            }

//            existingLocation.Title = location.Title;
//            existingLocation.SubTitle = location.SubTitle;
//            existingLocation.Type = location.Type;
//            existingLocation.Rooms = location.Rooms;
//            existingLocation.NumberOfGuests = location.NumberOfGuests;
//            existingLocation.Features = location.Features;
//            existingLocation.Images = location.Images;
//            existingLocation.PricePerDay = location.PricePerDay;
//            existingLocation.Reservations = location.Reservations;
//            existingLocation.Landlord = location.Landlord;

//            _context.SaveChanges();
//        }
//    }
//}
