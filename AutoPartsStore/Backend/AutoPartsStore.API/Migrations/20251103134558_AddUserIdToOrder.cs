using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsStore.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 737, DateTimeKind.Utc).AddTicks(3239), new DateTime(2025, 11, 3, 13, 44, 42, 737, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1670), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1685), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1689), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1695), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1700), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1704), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1709), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1713), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1756), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1761), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1765), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1771), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1775), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1780), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1785), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1811), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1816), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1821), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1826), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1830), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1836), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1841), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1867), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1871), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1876), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1880), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1886), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1890), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1894), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1935), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1961), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1967), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1971), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1977), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1981), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1986), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1991), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2016), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2021), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2025), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2030), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2035), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2040), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2045), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2049), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2074), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2078), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2084), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2088), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2093), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2098), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2103), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2127), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2132), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2137), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2142), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2146), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2152), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2156), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2161), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2186), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2191), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2196), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2201), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2205), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2211), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2233), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2237), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2243), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2247), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2252), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2257), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2261), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2265), new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2266) });
        }
    }
}
