using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class addedSomethinElse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "Image", "ReleaseDate", "Title" },
                values: new object[] { 7, "https://upload.wikimedia.org/wikipedia/commons/a/ad/Somethin%E2%80%99_Else.jpg", 1958, "Somethin' Else" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e65fb911-5173-4d07-bd4b-902477c60ba4", "AQAAAAEAACcQAAAAEGfg8zlO4Rw/seAvU9QHhtO0gjqvoCJIvD4H8PoJsaH2S9K47TbXdCiKxtiowaQLSQ==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 25,
                column: "InstrumentTypeId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Musician",
                columns: new[] { "Id", "Instrument", "InstrumentTypeId", "Name" },
                values: new object[,]
                {
                    { 26, "alto saxophone", 1, "Cannonball Adderley" },
                    { 27, "trumpet", 1, "Miles Davis" },
                    { 28, "piano", 2, "Hank Jones" },
                    { 29, "piano", 2, "Sam Jones" }
                });

            migrationBuilder.InsertData(
                table: "MusicianAlbum",
                columns: new[] { "Id", "AlbumId", "MusicianId" },
                values: new object[,]
                {
                    { 37, 7, 17 },
                    { 33, 7, 26 },
                    { 34, 7, 27 },
                    { 35, 7, 28 },
                    { 36, 7, 29 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6290802-eb0a-4957-a4a6-ace6c650a7da", "AQAAAAEAACcQAAAAEAme67eIyMZwENtx7gVBbBYAdo0bNUWtbkrlzQw/7mS7CuHE3YCpWailXzTrgun+dQ==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 25,
                column: "InstrumentTypeId",
                value: 2);
        }
    }
}
