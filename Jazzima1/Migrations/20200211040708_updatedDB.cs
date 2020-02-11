using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class updatedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "Image", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 20, "https://upload.wikimedia.org/wikipedia/en/b/bc/A_Night_in_Tunisia_%281960_album%29.jpg", 1961, "A Night In Tunisia" },
                    { 21, "https://upload.wikimedia.org/wikipedia/en/c/ca/Bluesnik.jpg", 1962, "Bluesnik" },
                    { 22, "https://upload.wikimedia.org/wikipedia/en/2/22/One_Flight_Up.jpg", 1965, "One Flight Up" },
                    { 23, "https://upload.wikimedia.org/wikipedia/en/7/78/The_Thing_to_Do_%28album%29.jpg", 1965, "The Thing To Do" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32681c1c-2f00-409f-9a5f-e3842e5c9bc4", "AQAAAAEAACcQAAAAEP2UsJP+WIWf/5ZthhB91AFwTM9NDY/hofvGucXJEMrCJHbcp+uKLjpkF6timl+HUw==" });

            migrationBuilder.InsertData(
                table: "Musician",
                columns: new[] { "Id", "Instrument", "InstrumentTypeId", "Name" },
                values: new object[,]
                {
                    { 49, "tenor saxophone", 1, "Dexter Gordon" },
                    { 50, "bass", 3, "Niels-Henning Ørsted Pedersen" },
                    { 51, "trumpet", 1, "Blue Mitchell" },
                    { 52, "tenor saxophone", 1, "Junior Cook" },
                    { 53, "piano", 2, "Chick Corea" },
                    { 54, "bass", 3, "Gene Taylor" },
                    { 55, "drums", 1, "Al Foster" }
                });

            migrationBuilder.InsertData(
                table: "MusicianAlbum",
                columns: new[] { "Id", "AlbumId", "MusicianId" },
                values: new object[,]
                {
                    { 95, 20, 26 },
                    { 112, 23, 53 },
                    { 111, 23, 52 },
                    { 110, 23, 51 },
                    { 108, 22, 50 },
                    { 105, 22, 49 },
                    { 109, 22, 39 },
                    { 107, 22, 24 },
                    { 106, 22, 36 },
                    { 104, 21, 41 },
                    { 103, 21, 20 },
                    { 102, 21, 24 },
                    { 101, 21, 6 },
                    { 100, 21, 37 },
                    { 99, 20, 21 },
                    { 98, 20, 48 },
                    { 97, 20, 28 },
                    { 96, 20, 15 },
                    { 113, 23, 54 },
                    { 114, 23, 55 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2490a48-e837-422d-bcb2-f3877a401892", "AQAAAAEAACcQAAAAEFQc4zMVk31LDrC/6nUJa8H2Y4notSZh9qTnMTb3aZ/x20reondUNs40FboWGsNULg==" });
        }
    }
}
