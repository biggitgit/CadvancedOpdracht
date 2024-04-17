using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Repositories.LandlordRepo
{
    public interface ILandlordRepository
    {
        public Landlord Get(int id);
        public void Add(Landlord landlord);
        public void Update(Landlord landlord);
        public void Delete(int id);
    }
}
