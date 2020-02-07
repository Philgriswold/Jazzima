using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class addedTheCooker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_MusicianAlbum_MusicianAlbumId",
                table: "Album");

            migrationBuilder.DropIndex(
                name: "IX_Album_MusicianAlbumId",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "MusicianAlbumId",
                table: "Album");

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "Image", "ReleaseDate", "Title" },
                values: new object[] { 6, "https://upload.wikimedia.org/wikipedia/en/e/ec/The_Cooker.jpg", 1958, "The Cooker" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6290802-eb0a-4957-a4a6-ace6c650a7da", "AQAAAAEAACcQAAAAEAme67eIyMZwENtx7gVBbBYAdo0bNUWtbkrlzQw/7mS7CuHE3YCpWailXzTrgun+dQ==" });

            migrationBuilder.InsertData(
                table: "Musician",
                columns: new[] { "Id", "Instrument", "InstrumentTypeId", "Name" },
                values: new object[,]
                {
                    { 24, "piano", 2, "Bobby Timmons" },
                    { 25, "baritone saxophone", 2, "Pepper Adams" }
                });

            migrationBuilder.InsertData(
                table: "MusicianAlbum",
                columns: new[] { "Id", "AlbumId", "MusicianId" },
                values: new object[,]
                {
                    { 28, 6, 22 },
                    { 31, 6, 19 },
                    { 32, 6, 18 },
                    { 30, 6, 24 },
                    { 29, 6, 25 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicianAlbum_AlbumId",
                table: "MusicianAlbum",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianAlbum_MusicianId",
                table: "MusicianAlbum",
                column: "MusicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicianAlbum_Album_AlbumId",
                table: "MusicianAlbum",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MusicianAlbum_Musician_MusicianId",
                table: "MusicianAlbum",
                column: "MusicianId",
                principalTable: "Musician",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicianAlbum_Album_AlbumId",
                table: "MusicianAlbum");

            migrationBuilder.DropForeignKey(
                name: "FK_MusicianAlbum_Musician_MusicianId",
                table: "MusicianAlbum");

            migrationBuilder.DropIndex(
                name: "IX_MusicianAlbum_AlbumId",
                table: "MusicianAlbum");

            migrationBuilder.DropIndex(
                name: "IX_MusicianAlbum_MusicianId",
                table: "MusicianAlbum");

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.AddColumn<int>(
                name: "MusicianAlbumId",
                table: "Album",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e03881e9-79ef-42b4-90be-a8bddcd83072", "AQAAAAEAACcQAAAAEOIdz3/3yH6Cubh3N/7AVW8R12nFTIASvmE+Ja4bSgWysv50PzXRGlGObILkVrkUEw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Album_MusicianAlbumId",
                table: "Album",
                column: "MusicianAlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_MusicianAlbum_MusicianAlbumId",
                table: "Album",
                column: "MusicianAlbumId",
                principalTable: "MusicianAlbum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
