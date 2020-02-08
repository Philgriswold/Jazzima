using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class updatedAlbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "Image", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 8, "https://upload.wikimedia.org/wikipedia/en/3/32/Newk%27s_Time.jpeg", 1959, "Newk's Time" },
                    { 9, "https://upload.wikimedia.org/wikipedia/en/0/0e/Off_to_the_Races.jpg", 1959, "Off To The Races" },
                    { 10, "https://upload.wikimedia.org/wikipedia/en/7/78/New_Soil.jpg", 1959, "New Soil" },
                    { 11, "https://upload.wikimedia.org/wikipedia/en/f/f1/Davis_Cup_%28album%29.jpg", 1960, "Davis Cup" },
                    { 12, "https://upload.wikimedia.org/wikipedia/en/d/d1/Open_Sesame_%28Freddie_Hubbard_album%29.jpg", 1960, "Open Sesame" },
                    { 13, "https://upload.wikimedia.org/wikipedia/en/9/94/AT%27s_Delight.jpg", 1960, "A.T's Delight" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67a1dd4f-d725-45bf-a45a-eb93f89a025f", "AQAAAAEAACcQAAAAEAczlp0cTpKDfPBZFyZpgraUxxZqtby6S7X5rPcHzlBN7zeLZibKi75yDO+Qp5JNtA==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 33,
                column: "Instrument",
                value: "drums");

            migrationBuilder.InsertData(
                table: "Musician",
                columns: new[] { "Id", "Instrument", "InstrumentTypeId", "Name" },
                values: new object[,]
                {
                    { 35, "piano", 2, "Wynton Kelly" },
                    { 36, "trumpet", 1, "Donald Byrd" },
                    { 38, "bass", 3, "Sam Jones" },
                    { 39, "drums", 4, "Art Taylor" },
                    { 40, "piano", 2, "Walter Davis Jr." },
                    { 41, "drums", 4, "Pete La Roca" },
                    { 42, "drums", 4, "Clifford Jarvis" },
                    { 43, "tenor saxophone", 1, "Stanley Turrentine" },
                    { 34, "tenor saxophone", 1, "Sonny Rollins" },
                    { 37, "alto saxophone", 1, "Jackie McLean" }
                });

            migrationBuilder.InsertData(
                table: "SavedAlbums",
                columns: new[] { "Id", "AlbumId", "UserId" },
                values: new object[] { 7, 7, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "MusicianAlbum",
                columns: new[] { "Id", "AlbumId", "MusicianId" },
                values: new object[,]
                {
                    { 40, 8, 16 },
                    { 52, 10, 41 },
                    { 53, 11, 40 },
                    { 50, 10, 40 },
                    { 65, 13, 39 },
                    { 57, 11, 39 },
                    { 47, 9, 39 },
                    { 60, 12, 38 },
                    { 56, 11, 38 },
                    { 46, 9, 38 },
                    { 55, 11, 37 },
                    { 48, 10, 37 },
                    { 43, 9, 37 },
                    { 54, 11, 36 },
                    { 49, 10, 36 },
                    { 42, 9, 36 },
                    { 63, 13, 35 },
                    { 45, 9, 35 },
                    { 41, 8, 18 },
                    { 44, 9, 25 },
                    { 51, 10, 19 },
                    { 61, 12, 42 },
                    { 58, 12, 2 },
                    { 62, 13, 43 },
                    { 64, 13, 19 },
                    { 38, 8, 34 },
                    { 39, 8, 35 },
                    { 59, 12, 13 }
                });

            migrationBuilder.InsertData(
                table: "SavedAlbums",
                columns: new[] { "Id", "AlbumId", "UserId" },
                values: new object[,]
                {
                    { 12, 12, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 10, 10, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 13, 13, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 9, 9, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 8, 8, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 11, 11, "00000000-ffff-ffff-ffff-ffffffffffff" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b67475b-a7f4-4eea-bcec-689bc1682003", "AQAAAAEAACcQAAAAEG+kFwQi5j2KbO6DMjsn5kcIPemhJMYVbjreusbijDFRxlmddJLAKD/oV75UaX5EFQ==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 33,
                column: "Instrument",
                value: "druma");
        }
    }
}
