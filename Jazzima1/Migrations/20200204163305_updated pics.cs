using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class updatedpics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://upload.wikimedia.org/wikipedia/en/7/7a/Maiden_Voyage_%28Hancock%29.jpg");

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://upload.wikimedia.org/wikipedia/en/4/4a/Point_of_Departure.jpg");

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://upload.wikimedia.org/wikipedia/en/4/41/The_Soothsayer.jpg");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a54d0e6-47dc-4c7b-bc3e-39680a87e891", "AQAAAAEAACcQAAAAEHMOyUzlAp9wgNgxUi+OJJ+5vDUpHianxs+KXEHC6kmZfGZ7I5O1pq5/4scCdKrYiQ==" });

            migrationBuilder.UpdateData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 1,
                column: "MusicianId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlbumId", "MusicianId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlbumId", "MusicianId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AlbumId", "MusicianId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "MusicianAlbum",
                columns: new[] { "Id", "AlbumId", "MusicianId" },
                values: new object[,]
                {
                    { 16, 3, 4 },
                    { 15, 1, 4 },
                    { 14, 2, 5 },
                    { 12, 3, 13 },
                    { 11, 3, 12 },
                    { 10, 3, 11 },
                    { 9, 2, 10 },
                    { 8, 2, 9 },
                    { 7, 2, 8 },
                    { 6, 2, 7 },
                    { 13, 1, 5 },
                    { 5, 2, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://en.wikipedia.org/wiki/File:Maiden_Voyage_(Hancock).jpg");

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://en.wikipedia.org/wiki/File:Point_of_Departure.jpg");

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://en.wikipedia.org/wiki/File:The_Soothsayer.jpg");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06417135-0b3c-4b75-a778-0533d759e16b", "AQAAAAEAACcQAAAAELI1CTKFRx/ZyK6X5S2DM8WH8Z3vCy+77ecWmWfH4J5/kxLZucju/mFAp0limCNX5g==" });

            migrationBuilder.UpdateData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 1,
                column: "MusicianId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlbumId", "MusicianId" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlbumId", "MusicianId" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AlbumId", "MusicianId" },
                values: new object[] { 3, 4 });
        }
    }
}
