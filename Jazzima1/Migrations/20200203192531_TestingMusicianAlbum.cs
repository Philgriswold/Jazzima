using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class TestingMusicianAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "868b1e47-d2e8-4ee7-a675-6671bc69c7d8", "AQAAAAEAACcQAAAAEHZhOSlmVdLSTQiKIS/zUSndjWTuOoLmK9FjBEIYE/S5uA/QLX3CU9snQlVJPASPVQ==" });

            migrationBuilder.InsertData(
                table: "MusicianAlbum",
                columns: new[] { "Id", "AlbumId", "MusicianId" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 2, 2, 5 },
                    { 3, 1, 4 },
                    { 4, 3, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e7db73a-2c8c-4abe-b6e2-ddc882157699", "AQAAAAEAACcQAAAAEAQeDt54d4hrEOH3D/ACZL9+HfkPNeYOjYVksTfphMVG/Sc2gVNh0l8JkbXYz8U8Cw==" });
        }
    }
}
