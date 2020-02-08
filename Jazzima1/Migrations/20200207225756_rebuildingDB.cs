using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class rebuildingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ffb2fbc8-4f0c-4a80-a776-216586cb9b19", "AQAAAAEAACcQAAAAEHD5Bj8EN/Iq903Ibg/BWjZI3amG/pU5xG1Gm1G2HboBD1fcJ98Ix1kz77FoLMYoxA==" });

            migrationBuilder.InsertData(
                table: "SavedAlbums",
                columns: new[] { "Id", "AlbumId", "UserId" },
                values: new object[] { 6, 6, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "SavedAlbums",
                columns: new[] { "Id", "AlbumId", "UserId" },
                values: new object[] { 5, 5, "00000000-ffff-ffff-ffff-ffffffffffff" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c0bcec1-daca-4f36-b3ec-34a3c3ef68c4", "AQAAAAEAACcQAAAAECn6iusskN5yeSMaIwYUi8cAUKSSO7AFGjtCFoExQWdLu9nLixlP+VZcBv+T9bWrRg==" });
        }
    }
}
