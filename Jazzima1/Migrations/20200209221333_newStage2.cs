using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class newStage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d59e46a-e405-4c19-86cb-92ab26df244a", "AQAAAAEAACcQAAAAEClnf6ZrUU+BFU3MTOiO5GQbXbUS9mJGPIALdaBv3gPXa5iDipXyVjlgnlggthqDpg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29330863-ac75-4657-a217-958e097283ea", "AQAAAAEAACcQAAAAEDsPTJLJaPnQ9um5B1kr+TBpTQ0wdQMqsn281lJ8kL1DfIAxiEnNRCefaQ3AmpnilQ==" });

            migrationBuilder.InsertData(
                table: "SavedAlbums",
                columns: new[] { "Id", "AlbumId", "UserId" },
                values: new object[,]
                {
                    { 11, 11, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 12, 12, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 13, 13, "00000000-ffff-ffff-ffff-ffffffffffff" }
                });
        }
    }
}
