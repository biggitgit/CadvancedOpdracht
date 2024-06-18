using Microsoft.EntityFrameworkCore;
using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Data
{
    public class CadvancedOpdrachtContext : DbContext
    {
        public CadvancedOpdrachtContext (DbContextOptions<CadvancedOpdrachtContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Landlord>().HasData(
                new Landlord { Id = 1, FirstName = "John", LastName = "Doe", Age = 40, AvatarId = 1 },
                new Landlord { Id = 2, FirstName = "Jane", LastName = "Smith", Age = 35, AvatarId = 2 },
                new Landlord { Id = 3, FirstName = "Alice", LastName = "Johnson", Age = 45, AvatarId = 3 }
            );

            modelBuilder.Entity<Image>().ToTable("Image");
            modelBuilder.Entity<Image>().HasData(
                new Image { ImageId = 1, Url = "url_van_afbeelding_1", IsCover = true },
                new Image { ImageId = 2, Url = "url_van_afbeelding_2", IsCover = false },
                new Image { ImageId = 3, Url = "url_van_afbeelding_3", IsCover = true }
            );

            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    Title = "Gezellig appartement",
                    SubTitle = "Centraal gelegen",
                    Description = "Een mooi appartement in het hart van de stad.",
                    Type = Location.LocationType.Appartement,
                    Rooms = 2,
                    NumberOfGuests = 4,
                    Features = Location.LocationFeatures.WiFi | Location.LocationFeatures.Keuken,
                    PricePerDay = 100,
                    LandlordId = 1
                },
                new Location
                {
                    Id = 2,
                    Title = "Luxe Villa aan Zee",
                    SubTitle = "Prachtig Uitzicht",
                    Description = "Een ruime villa direct aan het strand met alle luxe voorzieningen.",
                    Type = Location.LocationType.Villa,
                    Rooms = 5,
                    NumberOfGuests = 10,
                    Features = Location.LocationFeatures.WiFi | Location.LocationFeatures.AirConditioning | Location.LocationFeatures.Keuken,
                    PricePerDay = 500,
                    LandlordId = 1
                },
                new Location
                {
                    Id = 3,
                    Title = "Gezellige hotel in het Bos",
                    SubTitle = "Omringd door Natuur",
                    Description = "Een knusse hotel verscholen in het bos, perfect voor natuurliefhebbers.",
                    Type = Location.LocationType.Hotel,
                    Rooms = 1,
                    NumberOfGuests = 2,
                    Features = Location.LocationFeatures.WiFi | Location.LocationFeatures.AirConditioning,
                    PricePerDay = 80,
                    LandlordId = 2
                },
                new Location
                {
                    Id = 4,
                    Title = "Historisch Herenhuis",
                    SubTitle = "Charmant en Elegant",
                    Description = "Een prachtig gerestaureerd herenhuis met historische kenmerken en moderne voorzieningen.",
                    Type = Location.LocationType.Huis,
                    Rooms = 6,
                    NumberOfGuests = 8,
                    Features = Location.LocationFeatures.WiFi | Location.LocationFeatures.Verwarming | Location.LocationFeatures.Televisie | Location.LocationFeatures.Keuken,
                    PricePerDay = 300,
                    LandlordId = 2
                },
                new Location
                {
                    Id = 5,
                    Title = "Landelijk Boerderijtje",
                    SubTitle = "Rustieke Schoonheid",
                    Description = "Een gezellig boerderijtje op het platteland, omgeven door groene velden en rustieke charme.",
                    Type = Location.LocationType.Huis,
                    Rooms = 4,
                    NumberOfGuests = 6,
                    Features = Location.LocationFeatures.WiFi | Location.LocationFeatures.Verwarming | Location.LocationFeatures.Keuken,
                    PricePerDay = 150,
                    LandlordId = 3
                },
                new Location
                {
                    Id = 6,
                    Title = "Moderne Loft in het Stadscentrum",
                    SubTitle = "Stijlvol en Comfortabel",
                    Description = "Een trendy loft-appartement met strakke lijnen en moderne inrichting, perfect voor een stedelijke ervaring.",
                    Type = Location.LocationType.Appartement,
                    Rooms = 1,
                    NumberOfGuests = 2,
                    Features = Location.LocationFeatures.WiFi | Location.LocationFeatures.AirConditioning | Location.LocationFeatures.Keuken,
                    PricePerDay = 150,
                    LandlordId = 3
                },
                new Location
                {
                    Id = 7,
                    Title = "Exclusieve Bergchalet",
                    SubTitle = "Adembenemend Uitzicht",
                    Description = "Een afgelegen chalet hoog in de bergen, met panoramisch uitzicht op de omliggende natuur en alle luxe voorzieningen voor een onvergetelijk verblijf.",
                    Type = Location.LocationType.Huis,
                    Rooms = 3,
                    NumberOfGuests = 6,
                    Features = Location.LocationFeatures.WiFi | Location.LocationFeatures.Verwarming | Location.LocationFeatures.Televisie | Location.LocationFeatures.Keuken,
                    PricePerDay = 250,
                    LandlordId = 1
                },
                new Location
                {
                    Id = 8,
                    Title = "Gezinsvriendelijk Strandhuis",
                    SubTitle = "Direct aan Zee",
                    Description = "Een charmant strandhuisje met voldoende ruimte voor het hele gezin, op slechts een steenworp afstand van het zand en de golven.",
                    Type = Location.LocationType.Huis,
                    Rooms = 4,
                    NumberOfGuests = 8,
                    Features = Location.LocationFeatures.WiFi | Location.LocationFeatures.Verwarming | Location.LocationFeatures.Televisie | Location.LocationFeatures.Keuken,
                    PricePerDay = 200,
                    LandlordId = 2
                },
                new Location
                {
                    Id = 9,
                    Title = "Romantische Boomhut Retreat",
                    SubTitle = "Omgeven door Natuur",
                    Description = "Een betoverende boomhut op een afgelegen locatie, perfect voor een romantisch uitje midden in de natuur met alle moderne gemakken.",
                    Type = Location.LocationType.Huis,
                    Rooms = 1,
                    NumberOfGuests = 2,
                    Features = Location.LocationFeatures.WiFi | Location.LocationFeatures.Verwarming,
                    PricePerDay = 120,
                    LandlordId = 3
                },
                new Location
                {
                    Id = 10,
                    Title = "Sfeervolle Bungalow aan het Meer",
                    SubTitle = "Idyllisch Uitzicht",
                    Description = "Een pittoreske bungalow direct aan het meer, omgeven door rust en natuurlijke schoonheid, perfect voor een ontspannen vakantie weg van de drukte van het stadsleven.",
                    Type = Location.LocationType.Huis,
                    Rooms = 2,
                    NumberOfGuests = 4,
                    Features = Location.LocationFeatures.WiFi | Location.LocationFeatures.Verwarming | Location.LocationFeatures.Keuken,
                    PricePerDay = 180,
                    LandlordId = 1
                }
            );

            modelBuilder.Entity<Image>().HasData(
                // Images for Location 1
                new Image { ImageId = 4, Url = "url_van_afbeelding_1", IsCover = true, LocationId = 1 },
                new Image { ImageId = 5, Url = "url_van_afbeelding_2", IsCover = false, LocationId = 1 },
                // Images for Location 2
                new Image { ImageId = 6, Url = "url_van_afbeelding_3", IsCover = true, LocationId = 2 },
                new Image { ImageId = 7, Url = "url_van_afbeelding_4", IsCover = false, LocationId = 2 },
                // Images for Location 3
                new Image { ImageId = 8, Url = "url_van_afbeelding_5", IsCover = true, LocationId = 3 },
                new Image { ImageId = 9, Url = "url_van_afbeelding_6", IsCover = false, LocationId = 3 },
                // Images for Location 4
                new Image { ImageId = 10, Url = "url_van_afbeelding_7", IsCover = true, LocationId = 4 },
                new Image { ImageId = 11, Url = "url_van_afbeelding_8", IsCover = false, LocationId = 4 },
                // Images for Location 5
                new Image { ImageId = 12, Url = "url_van_afbeelding_9", IsCover = true, LocationId = 5 },
                new Image { ImageId = 13, Url = "url_van_afbeelding_10", IsCover = false, LocationId = 5 },
                // Images for Location 6
                new Image { ImageId = 14, Url = "url_van_afbeelding_11", IsCover = true, LocationId = 6 },
                new Image { ImageId = 15, Url = "url_van_afbeelding_12", IsCover = false, LocationId = 6 },
                // Images for Location 7
                new Image { ImageId = 16, Url = "url_van_afbeelding_13", IsCover = true, LocationId = 7 },
                new Image { ImageId = 17, Url = "url_van_afbeelding_14", IsCover = false, LocationId = 7 },
                // Images for Location 8
                new Image { ImageId = 18, Url = "url_van_afbeelding_15", IsCover = true, LocationId = 8 },
                new Image { ImageId = 19, Url = "url_van_afbeelding_16", IsCover = false, LocationId = 8 },
                // Images for Location 9
                new Image { ImageId = 20, Url = "url_van_afbeelding_17", IsCover = true, LocationId = 9 },
                new Image { ImageId = 21, Url = "url_van_afbeelding_18", IsCover = false, LocationId = 9 },
                // Images for Location 10
                new Image { ImageId = 22, Url = "url_van_afbeelding_19", IsCover = true, LocationId = 10 },
                new Image { ImageId = 23, Url = "url_van_afbeelding_20", IsCover = false, LocationId = 10 }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" },
                new Customer { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com" },
                new Customer { Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com" }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, LocationId = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7), CustomerId = 1, Discount = 10.0f },
                new Reservation { Id = 2, LocationId = 2, StartDate = DateTime.Now.AddDays(10), EndDate = DateTime.Now.AddDays(17), CustomerId = 2, Discount = 5.0f },
                new Reservation { Id = 3, LocationId = 3, StartDate = DateTime.Now.AddDays(20), EndDate = DateTime.Now.AddDays(27), CustomerId = 3, Discount = 15.0f }
            );

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Reservations)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId);

            modelBuilder.Entity<Location>()
                .HasMany(l => l.Reservations)
                .WithOne(r => r.Location)
                .HasForeignKey(r => r.LocationId);

            modelBuilder.Entity<Landlord>()
                .HasMany(l => l.Locations)
                .WithOne(loc => loc.Landlord)
                .HasForeignKey(loc => loc.LandlordId);

            modelBuilder.Entity<Location>()
                .HasMany(l => l.Images)
                .WithOne(i => i.Location)
                .HasForeignKey(i => i.LocationId);

            modelBuilder.Entity<Landlord>()
                .HasOne(l => l.Avatar)
                .WithOne()
                .HasForeignKey<Landlord>(l => l.AvatarId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CadvancedOpdrachtContext-4f9b12d7-fba8-440c-9b43-921e89d32674;Trusted_Connection=True;");
        }
    }
}
