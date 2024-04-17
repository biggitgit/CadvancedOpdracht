using CadvancedOpdracht.Data;
using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Repositories.LandlordRepo
{
    public class LandlordRepository : ILandlordRepository
    {
        private readonly CadvancedOpdrachtContext _context;

        public LandlordRepository(CadvancedOpdrachtContext context)
        {
            _context = context;
        }
        public void Add(Landlord landlord)
        {
            if (landlord == null)
            {
                throw new ArgumentNullException(nameof(landlord));
            }
            _context.Landlord.Add(landlord);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var landlord = _context.Landlord.Find(id);
            if (landlord == null)
                throw new InvalidOperationException($"Landlord with id {id} not found.");

            _context.Landlord.Remove(landlord);
            _context.SaveChanges();
        }

        public Landlord Get(int id)
        {
            return _context.Landlord.Find(id);
        }

        public void Update(Landlord landlord)
        {
            if (landlord == null)
            {
                throw new ArgumentNullException(nameof(landlord));
            }

            var existingLandlord = _context.Landlord.Find(landlord.Id);
            if (existingLandlord == null)
            {
                throw new InvalidOperationException($"Landlord with id {landlord.Id} not found.");
            }

            existingLandlord.FirstName = landlord.FirstName;
            existingLandlord.LastName = landlord.LastName;
            existingLandlord.Age = landlord.Age;
            existingLandlord.Avatar = landlord.Avatar;
            existingLandlord.Locations = landlord.Locations;

            _context.SaveChanges();
        }
    }
}
