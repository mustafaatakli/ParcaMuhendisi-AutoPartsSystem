using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsStore.API.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewsAndEmailFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 833, DateTimeKind.Utc).AddTicks(7928), new DateTime(2025, 11, 3, 14, 10, 16, 833, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1818), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1834), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1860), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1866), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1902), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1907), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1911), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1915), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1921), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1925), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1951), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1956), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1961), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1967), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1971), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1976), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1981), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2006), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2010), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2015), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2021), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2026), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2030), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2035), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2060), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2064), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2070), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2074), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2078), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2084), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2088), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2093), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2117), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2123), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2127), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2133), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2137), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2142), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2146), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2171), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2192), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2196), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2201), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2206), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2210), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2215), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2220), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2247), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2251), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2257), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2261), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2266), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3076), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3087), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3119), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3125), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3129), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3135), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3139), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3144), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3149), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3175), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3180), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3185), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3194), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3199), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3203), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3212), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3218), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3222), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3227), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3231), new DateTime(2025, 11, 3, 14, 10, 16, 835, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 231, DateTimeKind.Utc).AddTicks(8167), new DateTime(2025, 11, 3, 13, 45, 56, 231, DateTimeKind.Utc).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7055), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7109), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7137), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7143), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7147), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7152), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7156), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7160), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7166), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7170), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7195), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7200), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7205), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7210), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7215), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7220), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7224), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7252), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7256), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7260), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7266), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7271), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7276), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7280), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7305), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7309), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7315), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7319), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7324), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7329), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7333), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7339), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7363), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7368), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7372), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7378), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7382), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7408), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7412), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7438), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7443), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7448), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7453), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7457), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7462), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7467), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7471), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7497), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7501), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7506), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7511), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7516), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7520), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7526), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7549), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7555), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7559), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7564), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7568), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7574), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7578), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7605), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7609), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7614), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7619), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7624), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7628), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7633), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7638), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7643), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7648), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7652), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7657), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7661), new DateTime(2025, 11, 3, 13, 45, 56, 232, DateTimeKind.Utc).AddTicks(7661) });
        }
    }
}
