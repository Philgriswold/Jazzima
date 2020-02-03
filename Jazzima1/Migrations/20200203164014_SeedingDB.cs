using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class SeedingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "Image", "ReleaseDate", "Title" },
                values: new object[] { 1, "https://en.wikipedia.org/wiki/File:Maiden_Voyage_(Hancock).jpg", 1965, "Maiden Voyage" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4336b5c-0525-40b5-8724-a31e0a6fef34", "AQAAAAEAACcQAAAAEAgc0XowEWBdF1CXpzc5Sv4WyJjHBPbqfuIc5RoEQnh8HsgzhwHK7I6vEM8wseb9yg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83d720c7-d650-4cdc-815f-b2f5c6735a0c", "AQAAAAEAACcQAAAAEC1ETIRuM4hkhK8SoAg65M/vB0CCSQzMh/48EJ8X6wpSnA4CCHOF1XrSn+nRhHu1cQ==" });
        }
    }
}
