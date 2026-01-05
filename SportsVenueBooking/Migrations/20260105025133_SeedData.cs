using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "Id", "Address", "Avaliability", "CourtNumber", "TimeSlot" },
                values: new object[,]
                {
                    { 1, "Over There", "Avaliable", 1, new DateTime(2026, 1, 5, 10, 51, 33, 172, DateTimeKind.Local).AddTicks(8762) },
                    { 2, "Over There", "Unavaliable", 2, new DateTime(2026, 1, 5, 10, 51, 33, 172, DateTimeKind.Local).AddTicks(8772) },
                    { 3, "Over Here", "Avaliable", 2, new DateTime(2026, 1, 5, 10, 51, 33, 172, DateTimeKind.Local).AddTicks(8774) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
