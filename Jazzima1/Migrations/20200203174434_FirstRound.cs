using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class FirstRound : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "Image", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 2, "https://en.wikipedia.org/wiki/File:Point_of_Departure.jpg", 1965, "Point Of Departure" },
                    { 3, "https://en.wikipedia.org/wiki/File:The_Soothsayer.jpg", 1979, "The Soothsayer" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e7db73a-2c8c-4abe-b6e2-ddc882157699", "AQAAAAEAACcQAAAAEAQeDt54d4hrEOH3D/ACZL9+HfkPNeYOjYVksTfphMVG/Sc2gVNh0l8JkbXYz8U8Cw==" });

            migrationBuilder.InsertData(
                table: "Musician",
                columns: new[] { "Id", "Instrument", "Name" },
                values: new object[,]
                {
                    { 1, "piano", "Herbie Hancock" },
                    { 2, "trumpet", "Freddie Hubbard" },
                    { 3, "tenor saxophone", "George Coleman" },
                    { 4, "bass", "Ron Carter" },
                    { 5, "drums", "Tony Williams" },
                    { 6, "trumpet", "Kenny Dorham" },
                    { 7, "alto saxophone", "Eric Dolphy" },
                    { 8, "tenor saxophone", "Joe Henderson" },
                    { 9, "piano", "Andrew Hill" },
                    { 10, "bass", "Richard Davis" },
                    { 11, "tenor saxophone", "Wayne Shorter" },
                    { 12, "alto saxophone", "James Spaulding" },
                    { 13, "piano", "McCoy Tyner" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4336b5c-0525-40b5-8724-a31e0a6fef34", "AQAAAAEAACcQAAAAEAgc0XowEWBdF1CXpzc5Sv4WyJjHBPbqfuIc5RoEQnh8HsgzhwHK7I6vEM8wseb9yg==" });
        }
    }
}
