using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class burnindb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "SavedAlbums",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06417135-0b3c-4b75-a778-0533d759e16b", "AQAAAAEAACcQAAAAELI1CTKFRx/ZyK6X5S2DM8WH8Z3vCy+77ecWmWfH4J5/kxLZucju/mFAp0limCNX5g==" });

            migrationBuilder.InsertData(
                table: "SavedAlbums",
                columns: new[] { "Id", "AlbumId", "UserId" },
                values: new object[] { 1, 1, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.CreateIndex(
                name: "IX_SavedAlbums_AlbumId",
                table: "SavedAlbums",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_SavedAlbums_Album_AlbumId",
                table: "SavedAlbums",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavedAlbums_Album_AlbumId",
                table: "SavedAlbums");

            migrationBuilder.DropIndex(
                name: "IX_SavedAlbums_AlbumId",
                table: "SavedAlbums");

            migrationBuilder.DeleteData(
                table: "SavedAlbums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "SavedAlbums",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "718595a5-85d4-4236-ba68-ccc2563e4a01", "AQAAAAEAACcQAAAAEG0zK5SIe65mgWmN7GADan7W70dvdPumX+I3SwWRdbuPY4xXIjbokAXPaZvnMepSdA==" });
        }
    }
}
