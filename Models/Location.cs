namespace CadvancedOpdracht.Models
{
    public class Location
    {
        public enum LocationType
        {
            Huis,
            Appartement,
            Villa
        }
        public enum LocationFeatures
        {
            WiFi,
            AirConditioning,
            Verwarming,
            Keuken,
            Televisie
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public LocationType Type { get; set; }
        public int Rooms { get; set; }
        public int NumberOfGuests { get; set; }
        public LocationFeatures Features { get; set; }
        public List<Image> Images { get; set; }
        public float PricePerDay { get; set; }
        public List<Reservation> Reservations { get; set; }
        public Landlord Landlord { get; set; }
    }
}
