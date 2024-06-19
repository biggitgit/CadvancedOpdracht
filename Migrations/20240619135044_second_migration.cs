using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadvancedOpdracht.Migrations
{
    /// <inheritdoc />
    public partial class second_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 1,
                columns: new[] { "IsCover", "LocationId", "Url" },
                values: new object[] { false, 9, "https://www.seo-snel.nl/profielfoto/profielfoto.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 2,
                columns: new[] { "LocationId", "Url" },
                values: new object[] { 9, "https://img.freepik.com/free-vector/isolated-young-handsome-man-different-poses-white-background-illustration_632498-859.jpg?size=338&ext=jpg&ga=GA1.1.1141335507.1718409600&semt=ais_user" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 3,
                columns: new[] { "IsCover", "LocationId", "Url" },
                values: new object[] { false, 9, "https://w0.peakpx.com/wallpaper/979/89/HD-wallpaper-purple-smile-design-eye-smily-profile-pic-face-thumbnail.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "Url",
                value: "https://www.groothuisbouw.nl/thumbs/764%C3%97999%C3%97n/vraag-antwoord/2022/04/1.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "Url",
                value: "https://smartzine.nl/wp-content/uploads/2022/04/profielfoto-maken.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "Url",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQlKeirJrSOg6G_7Y-Z5MfpyTJGgqVqqMZliw&s");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "Url",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRuvk72iiUWavgN022PZ-gY5y000c2-Loi67w&s");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "Url",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ3i-PZcn1_LzJUuQPrRaOXZ7IqHynefrkhZg&s");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "Url",
                value: "https://www.architectuurwonen.nl/wp-content/uploads/bb-plugin/cache/AW_Moderne-Vlinder-Voorgevel-web-panorama-aa2a77407e6982b4da6d3515c26821aa-5f5235edcba58.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "Url",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAjAo6ap7vtwohk0BL5XVavPeVXwBNibOlnA&s");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 11,
                column: "Url",
                value: "https://www.brummelhuis.nl/assets/img/lq/header-slide-2-2023.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "Url",
                value: "https://archivaldesigns.com/cdn/shop/products/Peach-Tree-Front_1200x.jpg?v=1648224612");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 13,
                column: "Url",
                value: "https://img.onmanorama.com/content/dam/mm/en/lifestyle/decor/images/2023/6/1/house-middleclass.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 14,
                column: "Url",
                value: "https://www.realestate.com.au/news-image/w_2560,h_1707/v1694583569/news-lifestyle-content-assets/wp-content/production/NAPIER-53-1517.jpg?_i=AA");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 15,
                column: "Url",
                value: "https://images.surferseo.art/fdb08e2e-5d39-402c-ad0c-8a3293301d9e.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 16,
                column: "Url",
                value: "https://image.cnbcfm.com/api/v1/image/103500764-GettyImages-147205632-2.jpg?v=1691157601");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 17,
                column: "Url",
                value: "https://res.cloudinary.com/brickandbatten/images/f_auto,q_auto/v1675439478/wordpress_assets/SmallHouseExteriors-Twitter-card-B-LOGO/SmallHouseExteriors-Twitter-card-B-LOGO.jpg?_i=AA");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 18,
                column: "Url",
                value: "https://www.bankrate.com/2023/06/12125257/buying-a-house-worth-it.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 19,
                column: "Url",
                value: "https://cdn.houseplansservices.com/product/pk8ecmlmjnbibk8r5fr01oje77/w620x413.jpg?v=2");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 20,
                column: "Url",
                value: "https://res.akamaized.net/domain/image/upload/t_web/v1538713881/bigsmall_Mirvac_house2_twgogv.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 21,
                column: "Url",
                value: "https://www.bankrate.com/2022/07/20093642/what-is-house-poor.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 22,
                column: "Url",
                value: "https://ca-times.brightspotcdn.com/dims4/default/a517b34/2147483647/strip/false/crop/2000x1125+0+35/resize/1200x675!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2Fad%2Ff4%2F1f1b2193479eafb7cbba65691184%2F10480-sunset-fullres-01.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 23,
                column: "Url",
                value: "https://images.adsttc.com/media/images/5ecd/d4ac/b357/65c6/7300/009d/large_jpg/02C.jpg?1590547607");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 15, 50, 42, 993, DateTimeKind.Local).AddTicks(5077), new DateTime(2024, 6, 19, 15, 50, 42, 993, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 6, 15, 50, 42, 993, DateTimeKind.Local).AddTicks(5085), new DateTime(2024, 6, 29, 15, 50, 42, 993, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 16, 15, 50, 42, 993, DateTimeKind.Local).AddTicks(5091), new DateTime(2024, 7, 9, 15, 50, 42, 993, DateTimeKind.Local).AddTicks(5089) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 1,
                columns: new[] { "IsCover", "LocationId", "Url" },
                values: new object[] { true, null, "url_van_afbeelding_1" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 2,
                columns: new[] { "LocationId", "Url" },
                values: new object[] { null, "url_van_afbeelding_2" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 3,
                columns: new[] { "IsCover", "LocationId", "Url" },
                values: new object[] { true, null, "url_van_afbeelding_3" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "Url",
                value: "url_van_afbeelding_1");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "Url",
                value: "url_van_afbeelding_2");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "Url",
                value: "url_van_afbeelding_3");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "Url",
                value: "url_van_afbeelding_4");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "Url",
                value: "url_van_afbeelding_5");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "Url",
                value: "url_van_afbeelding_6");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "Url",
                value: "url_van_afbeelding_7");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 11,
                column: "Url",
                value: "url_van_afbeelding_8");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "Url",
                value: "url_van_afbeelding_9");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 13,
                column: "Url",
                value: "url_van_afbeelding_10");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 14,
                column: "Url",
                value: "url_van_afbeelding_11");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 15,
                column: "Url",
                value: "url_van_afbeelding_12");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 16,
                column: "Url",
                value: "url_van_afbeelding_13");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 17,
                column: "Url",
                value: "url_van_afbeelding_14");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 18,
                column: "Url",
                value: "url_van_afbeelding_15");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 19,
                column: "Url",
                value: "url_van_afbeelding_16");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 20,
                column: "Url",
                value: "url_van_afbeelding_17");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 21,
                column: "Url",
                value: "url_van_afbeelding_18");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 22,
                column: "Url",
                value: "url_van_afbeelding_19");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 23,
                column: "Url",
                value: "url_van_afbeelding_20");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6884), new DateTime(2024, 6, 18, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 5, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6892), new DateTime(2024, 6, 28, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 15, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6897), new DateTime(2024, 7, 8, 11, 26, 47, 905, DateTimeKind.Local).AddTicks(6895) });
        }
    }
}
