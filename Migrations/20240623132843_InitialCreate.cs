using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CadvancedOpdracht.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCover = table.Column<bool>(type: "bit", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Landlords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AvatarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landlords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landlords_Image_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Image",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false),
                    Features = table.Column<int>(type: "int", nullable: false),
                    PricePerDay = table.Column<float>(type: "real", nullable: false),
                    LandlordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Landlords_LandlordId",
                        column: x => x.LandlordId,
                        principalTable: "Landlords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "Doe" },
                    { 2, "jane.smith@example.com", "Jane", "Smith" },
                    { 3, "alice.johnson@example.com", "Alice", "Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 1, false, null, "https://www.seo-snel.nl/profielfoto/profielfoto.png" },
                    { 2, false, null, "https://img.freepik.com/free-vector/isolated-young-handsome-man-different-poses-white-background-illustration_632498-859.jpg?size=338&ext=jpg&ga=GA1.1.1141335507.1718409600&semt=ais_user" },
                    { 3, false, null, "https://w0.peakpx.com/wallpaper/979/89/HD-wallpaper-purple-smile-design-eye-smily-profile-pic-face-thumbnail.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 40, 1, "John", "Doe" },
                    { 2, 35, 2, "Jane", "Smith" },
                    { 3, 45, 3, "Alice", "Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "Een mooi appartement in het hart van de stad.", 12, 1, 4, 100f, 2, "Centraal gelegen", "Gezellig appartement", 0 },
                    { 2, "Een ruime villa direct aan het strand met alle luxe voorzieningen.", 60, 1, 10, 500f, 5, "Prachtig Uitzicht", "Luxe Villa aan Zee", 5 },
                    { 3, "Een knusse hotel verscholen in het bos, perfect voor natuurliefhebbers.", 36, 2, 2, 80f, 1, "Omringd door Natuur", "Gezellige hotel in het Bos", 4 },
                    { 4, "Een prachtig gerestaureerd herenhuis met historische kenmerken en moderne voorzieningen.", 28, 2, 8, 300f, 6, "Charmant en Elegant", "Historisch Herenhuis", 5 },
                    { 5, "Een gezellig boerderijtje op het platteland, omgeven door groene velden en rustieke charme.", 6, 3, 6, 150f, 4, "Rustieke Schoonheid", "Landelijk Boerderijtje", 1 },
                    { 6, "Een trendy loft-appartement met strakke lijnen en moderne inrichting, perfect voor een stedelijke ervaring.", 12, 3, 2, 150f, 1, "Stijlvol en Comfortabel", "Moderne Loft in het Stadscentrum", 0 },
                    { 7, "Een afgelegen chalet hoog in de bergen, met panoramisch uitzicht op de omliggende natuur en alle luxe voorzieningen voor een onvergetelijk verblijf.", 28, 1, 6, 250f, 3, "Adembenemend Uitzicht", "Exclusieve Bergchalet", 2 },
                    { 8, "Een charmant strandhuisje met voldoende ruimte voor het hele gezin, op slechts een steenworp afstand van het zand en de golven.", 44, 2, 8, 200f, 4, "Direct aan Zee", "Gezinsvriendelijk Strandhuis", 5 },
                    { 9, "Een betoverende boomhut op een afgelegen locatie, perfect voor een romantisch uitje midden in de natuur met alle moderne gemakken.", 36, 3, 2, 120f, 1, "Omgeven door Natuur", "Romantische Boomhut Retreat", 1 },
                    { 10, "Een pittoreske bungalow direct aan het meer, omgeven door rust en natuurlijke schoonheid, perfect voor een ontspannen vakantie weg van de drukte van het stadsleven.", 44, 1, 4, 180f, 2, "Idyllisch Uitzicht", "Sfeervolle Bungalow aan het Meer", 5 }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 4, true, 1, "https://www.groothuisbouw.nl/thumbs/764%C3%97999%C3%97n/vraag-antwoord/2022/04/1.jpg" },
                    { 5, false, 1, "https://smartzine.nl/wp-content/uploads/2022/04/profielfoto-maken.jpg" },
                    { 6, true, 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQlKeirJrSOg6G_7Y-Z5MfpyTJGgqVqqMZliw&s" },
                    { 7, false, 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRuvk72iiUWavgN022PZ-gY5y000c2-Loi67w&s" },
                    { 8, true, 3, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ3i-PZcn1_LzJUuQPrRaOXZ7IqHynefrkhZg&s" },
                    { 9, false, 3, "https://www.architectuurwonen.nl/wp-content/uploads/bb-plugin/cache/AW_Moderne-Vlinder-Voorgevel-web-panorama-aa2a77407e6982b4da6d3515c26821aa-5f5235edcba58.jpg" },
                    { 10, true, 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAjAo6ap7vtwohk0BL5XVavPeVXwBNibOlnA&s" },
                    { 11, false, 4, "https://www.brummelhuis.nl/assets/img/lq/header-slide-2-2023.jpg" },
                    { 12, true, 5, "https://archivaldesigns.com/cdn/shop/products/Peach-Tree-Front_1200x.jpg?v=1648224612" },
                    { 13, false, 5, "https://img.onmanorama.com/content/dam/mm/en/lifestyle/decor/images/2023/6/1/house-middleclass.jpg" },
                    { 14, true, 6, "https://www.realestate.com.au/news-image/w_2560,h_1707/v1694583569/news-lifestyle-content-assets/wp-content/production/NAPIER-53-1517.jpg?_i=AA" },
                    { 15, false, 6, "https://images.surferseo.art/fdb08e2e-5d39-402c-ad0c-8a3293301d9e.png" },
                    { 16, true, 7, "https://image.cnbcfm.com/api/v1/image/103500764-GettyImages-147205632-2.jpg?v=1691157601" },
                    { 17, false, 7, "https://res.cloudinary.com/brickandbatten/images/f_auto,q_auto/v1675439478/wordpress_assets/SmallHouseExteriors-Twitter-card-B-LOGO/SmallHouseExteriors-Twitter-card-B-LOGO.jpg?_i=AA" },
                    { 18, true, 8, "https://www.bankrate.com/2023/06/12125257/buying-a-house-worth-it.jpg" },
                    { 19, false, 8, "https://cdn.houseplansservices.com/product/pk8ecmlmjnbibk8r5fr01oje77/w620x413.jpg?v=2" },
                    { 20, true, 9, "https://res.akamaized.net/domain/image/upload/t_web/v1538713881/bigsmall_Mirvac_house2_twgogv.jpg" },
                    { 21, false, 9, "https://www.bankrate.com/2022/07/20093642/what-is-house-poor.jpg" },
                    { 22, true, 10, "https://ca-times.brightspotcdn.com/dims4/default/a517b34/2147483647/strip/false/crop/2000x1125+0+35/resize/1200x675!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2Fad%2Ff4%2F1f1b2193479eafb7cbba65691184%2F10480-sunset-fullres-01.jpg" },
                    { 23, false, 10, "https://images.adsttc.com/media/images/5ecd/d4ac/b357/65c6/7300/009d/large_jpg/02C.jpg?1590547607" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 10f, new DateTime(2024, 6, 30, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1322), 1, new DateTime(2024, 6, 23, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1269) },
                    { 2, 2, 5f, new DateTime(2024, 7, 10, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1331), 2, new DateTime(2024, 7, 3, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1328) },
                    { 3, 3, 15f, new DateTime(2024, 7, 20, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1336), 3, new DateTime(2024, 7, 13, 15, 28, 41, 639, DateTimeKind.Local).AddTicks(1334) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_LocationId",
                table: "Image",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Landlords_AvatarId",
                table: "Landlords",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LandlordId",
                table: "Locations",
                column: "LandlordId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_LocationId",
                table: "Reservations",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Locations_LocationId",
                table: "Image",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Locations_LocationId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Landlords");

            migrationBuilder.DropTable(
                name: "Image");
        }
    }
}
