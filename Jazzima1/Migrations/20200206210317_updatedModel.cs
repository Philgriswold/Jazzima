using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class updatedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MusicianAlbumId",
                table: "Album",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "438cd24b-1c49-4dc0-bc2b-f931a98c162a", "AQAAAAEAACcQAAAAEMzNxxW0uDvipxT+UrzvcyP77GZlmdP94SjxRBPXAKDqDwA0mGGX9ILOoVrIfX47Dg==" });
        }
    }
}
