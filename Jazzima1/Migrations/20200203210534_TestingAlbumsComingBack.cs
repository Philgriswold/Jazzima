using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class TestingAlbumsComingBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Album",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "718595a5-85d4-4236-ba68-ccc2563e4a01", "AQAAAAEAACcQAAAAEG0zK5SIe65mgWmN7GADan7W70dvdPumX+I3SwWRdbuPY4xXIjbokAXPaZvnMepSdA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Album");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "868b1e47-d2e8-4ee7-a675-6671bc69c7d8", "AQAAAAEAACcQAAAAEHZhOSlmVdLSTQiKIS/zUSndjWTuOoLmK9FjBEIYE/S5uA/QLX3CU9snQlVJPASPVQ==" });
        }
    }
}
