using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class rebuildingDeletedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c0bcec1-daca-4f36-b3ec-34a3c3ef68c4", "AQAAAAEAACcQAAAAECn6iusskN5yeSMaIwYUi8cAUKSSO7AFGjtCFoExQWdLu9nLixlP+VZcBv+T9bWrRg==" });

            migrationBuilder.InsertData(
                table: "SavedAlbums",
                columns: new[] { "Id", "AlbumId", "UserId" },
                values: new object[,]
                {
                    { 2, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, 3, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, 4, "00000000-ffff-ffff-ffff-ffffffffffff" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc4e2dd0-d317-4851-b121-95ce531f80c0", "AQAAAAEAACcQAAAAECiKCvhJ3gBddYZu2izX1i24J7o2K6V1Cfu7Fz3CTS4rXUWafA0Ytn0zqzlVqqop7Q==" });
        }
    }
}
