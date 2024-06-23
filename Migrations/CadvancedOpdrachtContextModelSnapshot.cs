﻿// <auto-generated />
using System;
using CadvancedOpdracht.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadvancedOpdracht.Migrations
{
    [DbContext(typeof(CadvancedOpdrachtContext))]
    partial class CadvancedOpdrachtContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CadvancedOpdracht.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson"
                        });
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Image", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCover = false,
                            Url = "https://www.seo-snel.nl/profielfoto/profielfoto.png"
                        },
                        new
                        {
                            Id = 2,
                            IsCover = false,
                            Url = "https://img.freepik.com/free-vector/isolated-young-handsome-man-different-poses-white-background-illustration_632498-859.jpg?size=338&ext=jpg&ga=GA1.1.1141335507.1718409600&semt=ais_user"
                        },
                        new
                        {
                            Id = 3,
                            IsCover = false,
                            Url = "https://w0.peakpx.com/wallpaper/979/89/HD-wallpaper-purple-smile-design-eye-smily-profile-pic-face-thumbnail.jpg"
                        },
                        new
                        {
                            Id = 4,
                            IsCover = true,
                            LocationId = 1,
                            Url = "https://www.groothuisbouw.nl/thumbs/764%C3%97999%C3%97n/vraag-antwoord/2022/04/1.jpg"
                        },
                        new
                        {
                            Id = 5,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://smartzine.nl/wp-content/uploads/2022/04/profielfoto-maken.jpg"
                        },
                        new
                        {
                            Id = 6,
                            IsCover = true,
                            LocationId = 2,
                            Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQlKeirJrSOg6G_7Y-Z5MfpyTJGgqVqqMZliw&s"
                        },
                        new
                        {
                            Id = 7,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRuvk72iiUWavgN022PZ-gY5y000c2-Loi67w&s"
                        },
                        new
                        {
                            Id = 8,
                            IsCover = true,
                            LocationId = 3,
                            Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ3i-PZcn1_LzJUuQPrRaOXZ7IqHynefrkhZg&s"
                        },
                        new
                        {
                            Id = 9,
                            IsCover = false,
                            LocationId = 3,
                            Url = "https://www.architectuurwonen.nl/wp-content/uploads/bb-plugin/cache/AW_Moderne-Vlinder-Voorgevel-web-panorama-aa2a77407e6982b4da6d3515c26821aa-5f5235edcba58.jpg"
                        },
                        new
                        {
                            Id = 10,
                            IsCover = true,
                            LocationId = 4,
                            Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAjAo6ap7vtwohk0BL5XVavPeVXwBNibOlnA&s"
                        },
                        new
                        {
                            Id = 11,
                            IsCover = false,
                            LocationId = 4,
                            Url = "https://www.brummelhuis.nl/assets/img/lq/header-slide-2-2023.jpg"
                        },
                        new
                        {
                            Id = 12,
                            IsCover = true,
                            LocationId = 5,
                            Url = "https://archivaldesigns.com/cdn/shop/products/Peach-Tree-Front_1200x.jpg?v=1648224612"
                        },
                        new
                        {
                            Id = 13,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://img.onmanorama.com/content/dam/mm/en/lifestyle/decor/images/2023/6/1/house-middleclass.jpg"
                        },
                        new
                        {
                            Id = 14,
                            IsCover = true,
                            LocationId = 6,
                            Url = "https://www.realestate.com.au/news-image/w_2560,h_1707/v1694583569/news-lifestyle-content-assets/wp-content/production/NAPIER-53-1517.jpg?_i=AA"
                        },
                        new
                        {
                            Id = 15,
                            IsCover = false,
                            LocationId = 6,
                            Url = "https://images.surferseo.art/fdb08e2e-5d39-402c-ad0c-8a3293301d9e.png"
                        },
                        new
                        {
                            Id = 16,
                            IsCover = true,
                            LocationId = 7,
                            Url = "https://image.cnbcfm.com/api/v1/image/103500764-GettyImages-147205632-2.jpg?v=1691157601"
                        },
                        new
                        {
                            Id = 17,
                            IsCover = false,
                            LocationId = 7,
                            Url = "https://res.cloudinary.com/brickandbatten/images/f_auto,q_auto/v1675439478/wordpress_assets/SmallHouseExteriors-Twitter-card-B-LOGO/SmallHouseExteriors-Twitter-card-B-LOGO.jpg?_i=AA"
                        },
                        new
                        {
                            Id = 18,
                            IsCover = true,
                            LocationId = 8,
                            Url = "https://www.bankrate.com/2023/06/12125257/buying-a-house-worth-it.jpg"
                        },
                        new
                        {
                            Id = 19,
                            IsCover = false,
                            LocationId = 8,
                            Url = "https://cdn.houseplansservices.com/product/pk8ecmlmjnbibk8r5fr01oje77/w620x413.jpg?v=2"
                        },
                        new
                        {
                            Id = 20,
                            IsCover = true,
                            LocationId = 9,
                            Url = "https://res.akamaized.net/domain/image/upload/t_web/v1538713881/bigsmall_Mirvac_house2_twgogv.jpg"
                        },
                        new
                        {
                            Id = 21,
                            IsCover = false,
                            LocationId = 9,
                            Url = "https://www.bankrate.com/2022/07/20093642/what-is-house-poor.jpg"
                        },
                        new
                        {
                            Id = 22,
                            IsCover = true,
                            LocationId = 10,
                            Url = "https://ca-times.brightspotcdn.com/dims4/default/a517b34/2147483647/strip/false/crop/2000x1125+0+35/resize/1200x675!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2Fad%2Ff4%2F1f1b2193479eafb7cbba65691184%2F10480-sunset-fullres-01.jpg"
                        },
                        new
                        {
                            Id = 23,
                            IsCover = false,
                            LocationId = 10,
                            Url = "https://images.adsttc.com/media/images/5ecd/d4ac/b357/65c6/7300/009d/large_jpg/02C.jpg?1590547607"
                        });
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Landlord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("Landlords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 40,
                            AvatarId = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Age = 35,
                            AvatarId = 2,
                            FirstName = "Jane",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            Age = 45,
                            AvatarId = 3,
                            FirstName = "Alice",
                            LastName = "Johnson"
                        });
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Features")
                        .HasColumnType("int");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Een mooi appartement in het hart van de stad.",
                            Features = 12,
                            LandlordId = 1,
                            NumberOfGuests = 4,
                            PricePerDay = 100f,
                            Rooms = 2,
                            SubTitle = "Centraal gelegen",
                            Title = "Gezellig appartement",
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Een ruime villa direct aan het strand met alle luxe voorzieningen.",
                            Features = 60,
                            LandlordId = 1,
                            NumberOfGuests = 10,
                            PricePerDay = 500f,
                            Rooms = 5,
                            SubTitle = "Prachtig Uitzicht",
                            Title = "Luxe Villa aan Zee",
                            Type = 5
                        },
                        new
                        {
                            Id = 3,
                            Description = "Een knusse hotel verscholen in het bos, perfect voor natuurliefhebbers.",
                            Features = 36,
                            LandlordId = 2,
                            NumberOfGuests = 2,
                            PricePerDay = 80f,
                            Rooms = 1,
                            SubTitle = "Omringd door Natuur",
                            Title = "Gezellige hotel in het Bos",
                            Type = 4
                        },
                        new
                        {
                            Id = 4,
                            Description = "Een prachtig gerestaureerd herenhuis met historische kenmerken en moderne voorzieningen.",
                            Features = 28,
                            LandlordId = 2,
                            NumberOfGuests = 8,
                            PricePerDay = 300f,
                            Rooms = 6,
                            SubTitle = "Charmant en Elegant",
                            Title = "Historisch Herenhuis",
                            Type = 5
                        },
                        new
                        {
                            Id = 5,
                            Description = "Een gezellig boerderijtje op het platteland, omgeven door groene velden en rustieke charme.",
                            Features = 6,
                            LandlordId = 3,
                            NumberOfGuests = 6,
                            PricePerDay = 150f,
                            Rooms = 4,
                            SubTitle = "Rustieke Schoonheid",
                            Title = "Landelijk Boerderijtje",
                            Type = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "Een trendy loft-appartement met strakke lijnen en moderne inrichting, perfect voor een stedelijke ervaring.",
                            Features = 12,
                            LandlordId = 3,
                            NumberOfGuests = 2,
                            PricePerDay = 150f,
                            Rooms = 1,
                            SubTitle = "Stijlvol en Comfortabel",
                            Title = "Moderne Loft in het Stadscentrum",
                            Type = 0
                        },
                        new
                        {
                            Id = 7,
                            Description = "Een afgelegen chalet hoog in de bergen, met panoramisch uitzicht op de omliggende natuur en alle luxe voorzieningen voor een onvergetelijk verblijf.",
                            Features = 28,
                            LandlordId = 1,
                            NumberOfGuests = 6,
                            PricePerDay = 250f,
                            Rooms = 3,
                            SubTitle = "Adembenemend Uitzicht",
                            Title = "Exclusieve Bergchalet",
                            Type = 2
                        },
                        new
                        {
                            Id = 8,
                            Description = "Een charmant strandhuisje met voldoende ruimte voor het hele gezin, op slechts een steenworp afstand van het zand en de golven.",
                            Features = 44,
                            LandlordId = 2,
                            NumberOfGuests = 8,
                            PricePerDay = 200f,
                            Rooms = 4,
                            SubTitle = "Direct aan Zee",
                            Title = "Gezinsvriendelijk Strandhuis",
                            Type = 5
                        },
                        new
                        {
                            Id = 9,
                            Description = "Een betoverende boomhut op een afgelegen locatie, perfect voor een romantisch uitje midden in de natuur met alle moderne gemakken.",
                            Features = 36,
                            LandlordId = 3,
                            NumberOfGuests = 2,
                            PricePerDay = 120f,
                            Rooms = 1,
                            SubTitle = "Omgeven door Natuur",
                            Title = "Romantische Boomhut Retreat",
                            Type = 1
                        },
                        new
                        {
                            Id = 10,
                            Description = "Een pittoreske bungalow direct aan het meer, omgeven door rust en natuurlijke schoonheid, perfect voor een ontspannen vakantie weg van de drukte van het stadsleven.",
                            Features = 44,
                            LandlordId = 1,
                            NumberOfGuests = 4,
                            PricePerDay = 180f,
                            Rooms = 2,
                            SubTitle = "Idyllisch Uitzicht",
                            Title = "Sfeervolle Bungalow aan het Meer",
                            Type = 5
                        });
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Discount = 10f,
                            EndDate = new DateTime(2024, 6, 30, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1322),
                            LocationId = 1,
                            StartDate = new DateTime(2024, 6, 23, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1269)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Discount = 5f,
                            EndDate = new DateTime(2024, 7, 10, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1331),
                            LocationId = 2,
                            StartDate = new DateTime(2024, 7, 3, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1328)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            Discount = 15f,
                            EndDate = new DateTime(2024, 7, 20, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1336),
                            LocationId = 3,
                            StartDate = new DateTime(2024, 7, 13, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1334)
                        });
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Image", b =>
                {
                    b.HasOne("CadvancedOpdracht.Models.Location", "Location")
                        .WithMany("Images")
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Landlord", b =>
                {
                    b.HasOne("CadvancedOpdracht.Models.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Location", b =>
                {
                    b.HasOne("CadvancedOpdracht.Models.Landlord", "Landlord")
                        .WithMany("Locations")
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Reservation", b =>
                {
                    b.HasOne("CadvancedOpdracht.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CadvancedOpdracht.Models.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Landlord", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("CadvancedOpdracht.Models.Location", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
