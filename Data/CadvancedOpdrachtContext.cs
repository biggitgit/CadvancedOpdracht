using Microsoft.EntityFrameworkCore;
using CadvancedOpdracht.Models;
using System;

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



            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    Title = "Gezellig appartement",
                    SubTitle = "Centraal gelegen",
                    Description = "Een mooi appartement in het hart van de stad.",
                    Type = Location.LocationType.Appartment,
                    Rooms = 2,
                    NumberOfGuests = 4,
                    Features = Location.LocationFeatures.Wifi | Location.LocationFeatures.TV,
                    PricePerDay = 100,
                    LandlordId = 1
                },
                new Location
                {
                    Id = 2,
                    Title = "Luxe Villa aan Zee",
                    SubTitle = "Prachtig Uitzicht",
                    Description = "Een ruime villa direct aan het strand met alle luxe voorzieningen.",
                    Type = Location.LocationType.House,
                    Rooms = 5,
                    NumberOfGuests = 10,
                    Features = Location.LocationFeatures.Wifi | Location.LocationFeatures.TV | Location.LocationFeatures.Bath | Location.LocationFeatures.Breakfast,
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
                    Features = Location.LocationFeatures.Wifi | Location.LocationFeatures.Breakfast,
                    PricePerDay = 80,
                    LandlordId = 2
                },
                new Location
                {
                    Id = 4,
                    Title = "Historisch Herenhuis",
                    SubTitle = "Charmant en Elegant",
                    Description = "Een prachtig gerestaureerd herenhuis met historische kenmerken en moderne voorzieningen.",
                    Type = Location.LocationType.House,
                    Rooms = 6,
                    NumberOfGuests = 8,
                    Features = Location.LocationFeatures.Wifi | Location.LocationFeatures.TV | Location.LocationFeatures.Bath,
                    PricePerDay = 300,
                    LandlordId = 2
                },
                new Location
                {
                    Id = 5,
                    Title = "Landelijk Boerderijtje",
                    SubTitle = "Rustieke Schoonheid",
                    Description = "Een gezellig boerderijtje op het platteland, omgeven door groene velden en rustieke charme.",
                    Type = Location.LocationType.Cottage,
                    Rooms = 4,
                    NumberOfGuests = 6,
                    Features = Location.LocationFeatures.PetsAllowed | Location.LocationFeatures.Wifi,
                    PricePerDay = 150,
                    LandlordId = 3
                },
                new Location
                {
                    Id = 6,
                    Title = "Moderne Loft in het Stadscentrum",
                    SubTitle = "Stijlvol en Comfortabel",
                    Description = "Een trendy loft-appartement met strakke lijnen en moderne inrichting, perfect voor een stedelijke ervaring.",
                    Type = Location.LocationType.Appartment,
                    Rooms = 1,
                    NumberOfGuests = 2,
                    Features = Location.LocationFeatures.Wifi | Location.LocationFeatures.TV,
                    PricePerDay = 150,
                    LandlordId = 3
                },
                new Location
                {
                    Id = 7,
                    Title = "Exclusieve Bergchalet",
                    SubTitle = "Adembenemend Uitzicht",
                    Description = "Een afgelegen chalet hoog in de bergen, met panoramisch uitzicht op de omliggende natuur en alle luxe voorzieningen voor een onvergetelijk verblijf.",
                    Type = Location.LocationType.Chalet,
                    Rooms = 3,
                    NumberOfGuests = 6,
                    Features = Location.LocationFeatures.Wifi | Location.LocationFeatures.TV | Location.LocationFeatures.Bath,
                    PricePerDay = 250,
                    LandlordId = 1
                },
                new Location
                {
                    Id = 8,
                    Title = "Gezinsvriendelijk Strandhuis",
                    SubTitle = "Direct aan Zee",
                    Description = "Een charmant strandhuisje met voldoende ruimte voor het hele gezin, op slechts een steenworp afstand van het zand en de golven.",
                    Type = Location.LocationType.House,
                    Rooms = 4,
                    NumberOfGuests = 8,
                    Features = Location.LocationFeatures.Wifi | Location.LocationFeatures.TV | Location.LocationFeatures.Breakfast,
                    PricePerDay = 200,
                    LandlordId = 2
                },
                new Location
                {
                    Id = 9,
                    Title = "Romantische Boomhut Retreat",
                    SubTitle = "Omgeven door Natuur",
                    Description = "Een betoverende boomhut op een afgelegen locatie, perfect voor een romantisch uitje midden in de natuur met alle moderne gemakken.",
                    Type = Location.LocationType.Cottage,
                    Rooms = 1,
                    NumberOfGuests = 2,
                    Features = Location.LocationFeatures.Wifi | Location.LocationFeatures.Breakfast,
                    PricePerDay = 120,
                    LandlordId = 3
                },
                new Location
                {
                    Id = 10,
                    Title = "Sfeervolle Bungalow aan het Meer",
                    SubTitle = "Idyllisch Uitzicht",
                    Description = "Een pittoreske bungalow direct aan het meer, omgeven door rust en natuurlijke schoonheid, perfect voor een ontspannen vakantie weg van de drukte van het stadsleven.",
                    Type = Location.LocationType.House,
                    Rooms = 2,
                    NumberOfGuests = 4,
                    Features = Location.LocationFeatures.Wifi | Location.LocationFeatures.TV | Location.LocationFeatures.Breakfast,
                    PricePerDay = 180,
                    LandlordId = 1
                }
            );


            modelBuilder.Entity<Image>().ToTable("Image");

            modelBuilder.Entity<Image>().HasData(
                new Image { Id = 1, Url = "https://www.seo-snel.nl/profielfoto/profielfoto.png", IsCover = false },
                new Image { Id = 2, Url = "https://img.freepik.com/free-vector/isolated-young-handsome-man-different-poses-white-background-illustration_632498-859.jpg?size=338&ext=jpg&ga=GA1.1.1141335507.1718409600&semt=ais_user", IsCover = false },
                new Image { Id = 3, Url = "https://w0.peakpx.com/wallpaper/979/89/HD-wallpaper-purple-smile-design-eye-smily-profile-pic-face-thumbnail.jpg", IsCover = false },
                // Images for Location 1
                new Image { Id = 4, Url = "https://www.groothuisbouw.nl/thumbs/764%C3%97999%C3%97n/vraag-antwoord/2022/04/1.jpg", IsCover = true, LocationId = 1 },
                new Image { Id = 5, Url = "https://smartzine.nl/wp-content/uploads/2022/04/profielfoto-maken.jpg", IsCover = false, LocationId = 1 },
                // Images for Location 2
                new Image { Id = 6, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQlKeirJrSOg6G_7Y-Z5MfpyTJGgqVqqMZliw&s", IsCover = true, LocationId = 2 },
                new Image { Id = 7, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRuvk72iiUWavgN022PZ-gY5y000c2-Loi67w&s", IsCover = false, LocationId = 2 },
                // Images for Location 3
                new Image { Id = 8, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ3i-PZcn1_LzJUuQPrRaOXZ7IqHynefrkhZg&s", IsCover = true, LocationId = 3 },
                new Image { Id = 9, Url = "https://www.architectuurwonen.nl/wp-content/uploads/bb-plugin/cache/AW_Moderne-Vlinder-Voorgevel-web-panorama-aa2a77407e6982b4da6d3515c26821aa-5f5235edcba58.jpg", IsCover = false, LocationId = 3 },
                // Images for Location 4
                new Image { Id = 10, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAjAo6ap7vtwohk0BL5XVavPeVXwBNibOlnA&s", IsCover = true, LocationId = 4 },
                new Image { Id = 11, Url = "https://www.brummelhuis.nl/assets/img/lq/header-slide-2-2023.jpg", IsCover = false, LocationId = 4 },
                // Images for Location 5
                new Image { Id = 12, Url = "https://archivaldesigns.com/cdn/shop/products/Peach-Tree-Front_1200x.jpg?v=1648224612", IsCover = true, LocationId = 5 },
                new Image { Id = 13, Url = "https://img.onmanorama.com/content/dam/mm/en/lifestyle/decor/images/2023/6/1/house-middleclass.jpg", IsCover = false, LocationId = 5 },
                // Images for Location 6
                new Image { Id = 14, Url = "https://www.realestate.com.au/news-image/w_2560,h_1707/v1694583569/news-lifestyle-content-assets/wp-content/production/NAPIER-53-1517.jpg?_i=AA", IsCover = true, LocationId = 6 },
                new Image { Id = 15, Url = "https://images.surferseo.art/fdb08e2e-5d39-402c-ad0c-8a3293301d9e.png", IsCover = false, LocationId = 6 },
                // Images for Location 7
                new Image { Id = 16, Url = "https://image.cnbcfm.com/api/v1/image/103500764-GettyImages-147205632-2.jpg?v=1691157601", IsCover = true, LocationId = 7 },
                new Image { Id = 17, Url = "https://res.cloudinary.com/brickandbatten/images/f_auto,q_auto/v1675439478/wordpress_assets/SmallHouseExteriors-Twitter-card-B-LOGO/SmallHouseExteriors-Twitter-card-B-LOGO.jpg?_i=AA", IsCover = false, LocationId = 7 },
                // Images for Location 8
                new Image { Id = 18, Url = "https://www.bankrate.com/2023/06/12125257/buying-a-house-worth-it.jpg", IsCover = true, LocationId = 8 },
                new Image { Id = 19, Url = "https://cdn.houseplansservices.com/product/pk8ecmlmjnbibk8r5fr01oje77/w620x413.jpg?v=2", IsCover = false, LocationId = 8 },
                // Images for Location 9
                new Image { Id = 20, Url = "https://res.akamaized.net/domain/image/upload/t_web/v1538713881/bigsmall_Mirvac_house2_twgogv.jpg", IsCover = true, LocationId = 9 },
                new Image { Id = 21, Url = "https://www.bankrate.com/2022/07/20093642/what-is-house-poor.jpg", IsCover = false, LocationId = 9 },
                // Images for Location 10
                new Image { Id = 22, Url = "https://ca-times.brightspotcdn.com/dims4/default/a517b34/2147483647/strip/false/crop/2000x1125+0+35/resize/1200x675!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2Fad%2Ff4%2F1f1b2193479eafb7cbba65691184%2F10480-sunset-fullres-01.jpg", IsCover = true, LocationId = 10 },
                new Image { Id = 23, Url = "https://images.adsttc.com/media/images/5ecd/d4ac/b357/65c6/7300/009d/large_jpg/02C.jpg?1590547607", IsCover = false, LocationId = 10 }
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
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CadvancedOpdrachtContext-4f9b12d7-fba8-440c-9b43-921e89d32674;Trusted_Connection=True;");
        }
    }
}
