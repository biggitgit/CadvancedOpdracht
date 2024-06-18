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
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Landlord_Image_AvatarId",
                table: "Landlord");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Landlord_LandlordId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Costumer_CostumerId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Location_LocationId",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "Costumer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Landlord",
                table: "Landlord");

            migrationBuilder.DropIndex(
                name: "IX_Landlord_AvatarId",
                table: "Landlord");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "Landlord",
                newName: "Landlords");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Image",
                newName: "ImageId");

            migrationBuilder.RenameColumn(
                name: "CostumerId",
                table: "Reservations",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_LocationId",
                table: "Reservations",
                newName: "IX_Reservations_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_CostumerId",
                table: "Reservations",
                newName: "IX_Reservations_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_LandlordId",
                table: "Locations",
                newName: "IX_Locations_LandlordId");

            migrationBuilder.AddColumn<int>(
                name: "LandlordId",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AvatarId",
                table: "Landlords",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Landlords",
                table: "Landlords",
                column: "Id");

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
                columns: new[] { "ImageId", "IsCover", "LandlordId", "LocationId", "Url" },
                values: new object[,]
                {
                    { 1, true, null, null, "url_van_afbeelding_1" },
                    { 2, false, null, null, "url_van_afbeelding_2" },
                    { 3, true, null, null, "url_van_afbeelding_3" }
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
                    { 1, "Een mooi appartement in het hart van de stad.", 3, 1, 4, 100f, 2, "Centraal gelegen", "Gezellig appartement", 2 },
                    { 2, "Een ruime villa direct aan het strand met alle luxe voorzieningen.", 3, 1, 10, 500f, 5, "Prachtig Uitzicht", "Luxe Villa aan Zee", 3 },
                    { 3, "Een knusse hotel verscholen in het bos, perfect voor natuurliefhebbers.", 1, 2, 2, 80f, 1, "Omringd door Natuur", "Gezellige hotel in het Bos", 4 },
                    { 4, "Een prachtig gerestaureerd herenhuis met historische kenmerken en moderne voorzieningen.", 7, 2, 8, 300f, 6, "Charmant en Elegant", "Historisch Herenhuis", 1 },
                    { 5, "Een gezellig boerderijtje op het platteland, omgeven door groene velden en rustieke charme.", 3, 3, 6, 150f, 4, "Rustieke Schoonheid", "Landelijk Boerderijtje", 1 },
                    { 6, "Een trendy loft-appartement met strakke lijnen en moderne inrichting, perfect voor een stedelijke ervaring.", 3, 3, 2, 150f, 1, "Stijlvol en Comfortabel", "Moderne Loft in het Stadscentrum", 2 },
                    { 7, "Een afgelegen chalet hoog in de bergen, met panoramisch uitzicht op de omliggende natuur en alle luxe voorzieningen voor een onvergetelijk verblijf.", 7, 1, 6, 250f, 3, "Adembenemend Uitzicht", "Exclusieve Bergchalet", 1 },
                    { 8, "Een charmant strandhuisje met voldoende ruimte voor het hele gezin, op slechts een steenworp afstand van het zand en de golven.", 7, 2, 8, 200f, 4, "Direct aan Zee", "Gezinsvriendelijk Strandhuis", 1 },
                    { 9, "Een betoverende boomhut op een afgelegen locatie, perfect voor een romantisch uitje midden in de natuur met alle moderne gemakken.", 2, 3, 2, 120f, 1, "Omgeven door Natuur", "Romantische Boomhut Retreat", 1 },
                    { 10, "Een pittoreske bungalow direct aan het meer, omgeven door rust en natuurlijke schoonheid, perfect voor een ontspannen vakantie weg van de drukte van het stadsleven.", 3, 1, 4, 180f, 2, "Idyllisch Uitzicht", "Sfeervolle Bungalow aan het Meer", 1 }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ImageId", "IsCover", "LandlordId", "LocationId", "Url" },
                values: new object[,]
                {
                    { 4, true, null, 1, "url_van_afbeelding_1" },
                    { 5, false, null, 1, "url_van_afbeelding_2" },
                    { 6, true, null, 2, "url_van_afbeelding_3" },
                    { 7, false, null, 2, "url_van_afbeelding_4" },
                    { 8, true, null, 3, "url_van_afbeelding_5" },
                    { 9, false, null, 3, "url_van_afbeelding_6" },
                    { 10, true, null, 4, "url_van_afbeelding_7" },
                    { 11, false, null, 4, "url_van_afbeelding_8" },
                    { 12, true, null, 5, "url_van_afbeelding_9" },
                    { 13, false, null, 5, "url_van_afbeelding_10" },
                    { 14, true, null, 6, "url_van_afbeelding_11" },
                    { 15, false, null, 6, "url_van_afbeelding_12" },
                    { 16, true, null, 7, "url_van_afbeelding_13" },
                    { 17, false, null, 7, "url_van_afbeelding_14" },
                    { 18, true, null, 8, "url_van_afbeelding_15" },
                    { 19, false, null, 8, "url_van_afbeelding_16" },
                    { 20, true, null, 9, "url_van_afbeelding_17" },
                    { 21, false, null, 9, "url_van_afbeelding_18" },
                    { 22, true, null, 10, "url_van_afbeelding_19" },
                    { 23, false, null, 10, "url_van_afbeelding_20" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 10f, new DateTime(2024, 6, 25, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6884), 1, new DateTime(2024, 6, 18, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6831) },
                    { 2, 2, 5f, new DateTime(2024, 7, 5, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6892), 2, new DateTime(2024, 6, 28, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6889) },
                    { 3, 3, 15f, new DateTime(2024, 7, 15, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6897), 3, new DateTime(2024, 7, 8, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6895) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_LandlordId",
                table: "Image",
                column: "LandlordId");

            migrationBuilder.CreateIndex(
                name: "IX_Landlords_AvatarId",
                table: "Landlords",
                column: "AvatarId",
                unique: true,
                filter: "[AvatarId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Landlords_LandlordId",
                table: "Image",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Locations_LocationId",
                table: "Image",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Landlords_Image_AvatarId",
                table: "Landlords",
                column: "AvatarId",
                principalTable: "Image",
                principalColumn: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Landlords_LandlordId",
                table: "Locations",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Locations_LocationId",
                table: "Reservations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Landlords_LandlordId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Locations_LocationId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Landlords_Image_AvatarId",
                table: "Landlords");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Landlords_LandlordId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Locations_LocationId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Image_LandlordId",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Landlords",
                table: "Landlords");

            migrationBuilder.DropIndex(
                name: "IX_Landlords_AvatarId",
                table: "Landlords");

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "LandlordId",
                table: "Image");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "Landlords",
                newName: "Landlord");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Image",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Reservation",
                newName: "CostumerId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_LocationId",
                table: "Reservation",
                newName: "IX_Reservation_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservation",
                newName: "IX_Reservation_CostumerId");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_LandlordId",
                table: "Location",
                newName: "IX_Location_LandlordId");

            migrationBuilder.AlterColumn<int>(
                name: "AvatarId",
                table: "Landlord",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Landlord",
                table: "Landlord",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Costumer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landlord_AvatarId",
                table: "Landlord",
                column: "AvatarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Landlord_Image_AvatarId",
                table: "Landlord",
                column: "AvatarId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Landlord_LandlordId",
                table: "Location",
                column: "LandlordId",
                principalTable: "Landlord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Costumer_CostumerId",
                table: "Reservation",
                column: "CostumerId",
                principalTable: "Costumer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Location_LocationId",
                table: "Reservation",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
