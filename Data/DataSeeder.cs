using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Data
{
    public class DataSeeder
    {
        public static void SeedData(CadvancedOpdrachtContext context)
        {
            if (context.Landlord.Any() || context.Location.Any() || context.Image.Any())
            {
                Console.WriteLine("Er is al geseed");
                return;
            }

            Console.WriteLine("Er wordt nu geseed");
            var landlords = new List<Landlord>
            {
                new Landlord { FirstName = "John", LastName = "Doe", Age = 40 },
                new Landlord { FirstName = "Jane", LastName = "Smith", Age = 35 },
                new Landlord { FirstName = "Alice", LastName = "Johnson", Age = 45 }
            };
            context.Landlord.AddRange(landlords);
            context.SaveChanges();

            var locations = new List<Location>
            {
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
                    Images = new List<Image>
                    {
                        new Image { Url = "url_van_afbeelding_1", Id = 1},
                        new Image { Url = "url_van_afbeelding_2", Id = 2},
                    }
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
                    Images = new List<Image>
                    {
                        new Image { Url = "url_van_afbeelding_1", Id = 3},
                        new Image { Url = "url_van_afbeelding_2", Id = 4},
                    }
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
                    Images = new List<Image>
                    {
                        new Image { Url = "url_van_afbeelding_1", Id = 5},
                        new Image { Url = "url_van_afbeelding_2", Id = 6},
                    }
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
                    Images = new List<Image>
                    {
                        new Image { Url = "url_van_afbeelding_1", Id = 7},
                        new Image { Url = "url_van_afbeelding_2", Id = 8},
                    }
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
                    Images = new List<Image>
                    {
                        new Image { Url = "url_van_afbeelding_1", Id = 9},
                        new Image { Url = "url_van_afbeelding_2", Id = 10},
                    }
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
                    Images = new List<Image>
                    {
                        new Image { Url = "url_van_afbeelding_1", Id = 11},
                        new Image { Url = "url_van_afbeelding_2", Id = 12},
                    }
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
                    Images = new List<Image>
                    {
                        new Image { Url = "url_van_afbeelding_1", Id = 13},
                        new Image { Url = "url_van_afbeelding_2", Id = 14},
                    }
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
                    Images = new List<Image>
                    {
                        new Image { Url = "url_van_afbeelding_1", Id = 15},
                        new Image { Url = "url_van_afbeelding_2", Id = 16},
                    }
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
                    Images = new List<Image>
                    {
                        new Image { Url = "url_van_afbeelding_1", Id = 17},
                        new Image { Url = "url_van_afbeelding_2", Id = 18},
                    }
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
                    Images = new List<Image>
                    {
                        new Image { Url = "url_van_afbeelding_1", Id = 19},
                        new Image { Url = "url_van_afbeelding_2", Id = 20,}
                    },
                } 
            };
            context.Location.AddRange(locations);
            context.SaveChanges();
        }
    }
}
